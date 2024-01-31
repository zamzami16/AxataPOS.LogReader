using AxataPOS.App.Helper;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AxataPOS.LogReader
{
    public partial class LogViewer : KryptonForm
    {
        private readonly LogReader _logReader;
        private IEnumerable<LogEntry> _logs;
        private Dictionary<string, IEnumerable<LogEntry>> _allLogEntries = new Dictionary<string, IEnumerable<LogEntry>>();
        private DataSet _pagedLogEntries;

        int BatchSize = Config.BATCH_SIZE;

        public LogViewer()
        {
            InitializeComponent();
            _logReader = new LogReader();
            DgvData.AutoGenerateColumns = false;
        }

        private void BtnBrowseFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select folder of log file.";

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolderPath = folderBrowserDialog.SelectedPath;
                    TxtFolder.Text = selectedFolderPath;
                }
            }
        }

        private void DgvData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DgvData.Columns[e.ColumnIndex].Name == "Level")
            {
                // Check the cell value
                if (e.Value != null)
                {
                    string level = e.Value.ToString();

                    // Change the row color based on the log level
                    switch (level)
                    {
                        case "Error":
                            DgvData.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                            break;

                        case "Warn":
                            DgvData.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.BlueViolet;
                            break;

                        case "Info":
                            DgvData.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Green;
                            break;
                    }
                }
            }
        }

        private void LogViewer_Load(object sender, EventArgs e)
        {
            TxtFolder.Text = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "AxataPOS");
            CboFiles.Items.Clear();
            CboFiles.Items.AddRange(new string[] { "", "Semua", "Pilih File" });
            CboFiles.Text = "";
            CboLevel.Items.Clear();
            CboLevel.SetItems<LogLevel>();
        }

        private void CboFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboFiles.Text == "Pilih File")
            {
                GetFile();
            }
            SupplyData();
        }

        private void GetFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
                Title = "Select a log file."
            };

            if (!string.IsNullOrWhiteSpace(TxtFolder.Text))
            {
                openFileDialog.InitialDirectory = TxtFolder.Text;
            }

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fullPath = openFileDialog.FileName;
                ReadFile(fullPath);
            }
        }

        private void ReadFile(string fullPath)
        {
            string fileName = Path.GetFileName(fullPath);
            if (_allLogEntries.ContainsKey(fileName))
            {
                return;
            }

            CboFiles.Items.Add(fileName);
            CboFiles.Text = fileName;
            try
            {
                _allLogEntries.Add(fileName, _logReader.ReadLogFile(fullPath));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading JSON file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeLblDates()
        {
            DateTime max = DateTime.Now;
            DateTime min = DateTime.Now;

            if (_allLogEntries != null && _allLogEntries.Any())
            {
                max = _allLogEntries.SelectMany(l => l.Value).Max(l => l.Time);
                min = _allLogEntries.SelectMany(l => l.Value).Min(l => l.Time);
            }
            lblDates.Text = $"All: {min:yyyy/MM/dd}  s/d  {max:yyyy/MM/dd}";
        }

        private void SupplyData()
        {
            ChangeLblDates();

            if (CboFiles.Text.Equals("", StringComparison.OrdinalIgnoreCase))
            {
                return;
            }

            bool showAll = false;
            if (CboFiles.Text.Equals("Semua", StringComparison.OrdinalIgnoreCase))
            {
                showAll = true;
                _logs = _allLogEntries.SelectMany(l => l.Value).ToList();
            }

            if (!showAll && !_allLogEntries.ContainsKey(CboFiles.Text))
            {
                return;
            }

            if (!showAll)
            {
                _logs = _allLogEntries[CboFiles.Text];
            }

            LogFilter logFilter = new LogFilter()
            {
                Filters = TxtSerach.Text,
                DateStart = DtpStart.Value.Date,
                DateEnd = DtpEnd.Value.Date,
                LogLevel = CboLevel.GetSelectedEnumValue<LogLevel>(),
                CurrentPage = pageControl.CurrentPage,
                PageCount = pageControl.TotalPages,
            };

            var data = _logs.Filters(logFilter);
            int totalPages = (int)Math.Ceiling((decimal)data.Count() / BatchSize);
            pageControl.TotalPages = totalPages;
            pageControl.CurrentPage = 1;
            _pagedLogEntries = PagedLogEntries(data, BatchSize, totalPages);
            SupplyPagedData();
        }

        private DataSet PagedLogEntries(IEnumerable<LogEntry> logs, int batchSize, int totalPage)
        {
            DataSet pagedData = new("data");

            if (logs.Count() is 0)
            {
                return pagedData;
            }

            // Ensure batchSize and totalPage are within valid ranges.
            batchSize = Math.Max(1, batchSize);
            totalPage = Math.Max(1, totalPage);

            // Convert the logs to a list for efficient indexing.
            List<LogEntry> logList = logs.ToList();

            for (int page = 1; page <= totalPage; page++)
            {
                int startIndex = (page - 1) * batchSize;
                int endIndex = Math.Min(startIndex + batchSize, logList.Count);

                IEnumerable<LogEntry> pageLogs = logList.Skip(startIndex).Take(endIndex - startIndex);

                DataTable table = pageLogs.ToDataTable($"page{page}");
                pagedData.Tables.Add(table);
            }

            return pagedData;
        }

        private void SupplyPagedData()
        {
            if (_pagedLogEntries is null)
            {
                return;
            }

            int page = pageControl.CurrentPage;
            DgvData.DataSource = null;
            if (page > 0)
            {
                if (_pagedLogEntries.Tables.Contains($"page{page}"))
                {
                    var value = _pagedLogEntries.Tables[$"page{page}"];
                    DgvData.DataSource = value;
                }
                else
                {
                    DgvData.DataSource = null;
                }
            }
        }

        private void kryptonDateTimePicker1_ValueChanged(object sender, EventArgs e)
            => SupplyData();

        private void CboLevel_SelectedIndexChanged(object sender, EventArgs e)
            => SupplyData();

        private void TxtSerach_KeyDown(object sender, KeyEventArgs e)
            => e.OnEnterPerform(() => SupplyData());

        private void DgvData_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var rowHeaderText = (e.RowIndex + 1).ToString();
            var dgv = sender as KryptonDataGridView;
            var FontCell = new Font("Trebuchet MS", 10F);
            using (SolidBrush brush = new SolidBrush(dgv.RowHeadersDefaultCellStyle.ForeColor))
            {
                var textFormat = new StringFormat()
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

                var bounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top - 1, dgv.RowHeadersWidth, e.RowBounds.Height);
                e.Graphics.DrawString(rowHeaderText, FontCell, brush, bounds, textFormat);
            }
        }

        private void MenuViewDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (RowIndex() == -1)
                {
                    return;
                }

                if (DgvData.DataSource is DataTable data)
                {
                    if (RowIndex() < data.Rows.Count)
                    {
                        DataRow row = data.Rows[RowIndex()];
                        LogEntry selectedLogEntry = row.ToLogEntry() ?? throw new ArgumentNullException(nameof(selectedLogEntry));
                        using (var frm = new Details())
                        {
                            frm.DataLog = selectedLogEntry;
                            frm.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int RowIndex()
            => DgvData.SelectedRows.Count > 0 ? DgvData.SelectedRows[0].Index : -1;

        private void pageControl_PageChanged(object sender, int e) => SupplyPagedData();

        private void DgvData_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var rowHeaderText = (e.RowIndex + 1).ToString();
            var dgv = sender as KryptonDataGridView;
            var FontCell = new Font("Trebuchet MS", 10F);
            using (SolidBrush brush = new SolidBrush(dgv.RowHeadersDefaultCellStyle.ForeColor))
            {
                var textFormat = new StringFormat()
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

                var bounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top - 1, dgv.RowHeadersWidth, e.RowBounds.Height);
                e.Graphics.DrawString(rowHeaderText, FontCell, brush, bounds, textFormat);
            }
        }

        private void LogViewer_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void LogViewer_DragDrop(object sender, DragEventArgs e)
        {
            // Retrieve the file paths from the data
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            // Perform operations with the file paths
            foreach (string file in files)
            {
                ReadFile(file);
            }
            SupplyData();
        }
    }
}
