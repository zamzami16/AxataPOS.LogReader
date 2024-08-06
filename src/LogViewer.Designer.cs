namespace AxataPOS.LogReader
{
    partial class LogViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogViewer));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.BtnBrowseFolder = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.TxtFolder = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.CboFiles = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.DtpStart = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.CboLevel = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.TxtSerach = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuViewDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.DtpEnd = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.DgvData = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.lblDates = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pageControl = new AxataPOS.LogReader.PageControl();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exception = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CboFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboLevel)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            // 
            // BtnBrowseFolder
            // 
            this.BtnBrowseFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBrowseFolder.Location = new System.Drawing.Point(924, 12);
            this.BtnBrowseFolder.Name = "BtnBrowseFolder";
            this.BtnBrowseFolder.Palette = this.kryptonPalette1;
            this.BtnBrowseFolder.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.BtnBrowseFolder.Size = new System.Drawing.Size(89, 25);
            this.BtnBrowseFolder.TabIndex = 0;
            this.BtnBrowseFolder.Values.Text = "Browse Folder";
            this.BtnBrowseFolder.Click += new System.EventHandler(this.BtnBrowseFolder_Click);
            // 
            // TxtFolder
            // 
            this.TxtFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFolder.Location = new System.Drawing.Point(483, 12);
            this.TxtFolder.Name = "TxtFolder";
            this.TxtFolder.Palette = this.kryptonPalette1;
            this.TxtFolder.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.TxtFolder.ReadOnly = true;
            this.TxtFolder.Size = new System.Drawing.Size(435, 23);
            this.TxtFolder.TabIndex = 1;
            this.TxtFolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CboFiles
            // 
            this.CboFiles.DropDownWidth = 260;
            this.CboFiles.Location = new System.Drawing.Point(12, 12);
            this.CboFiles.Name = "CboFiles";
            this.CboFiles.Size = new System.Drawing.Size(260, 21);
            this.CboFiles.TabIndex = 3;
            this.CboFiles.SelectedIndexChanged += new System.EventHandler(this.CboFiles_SelectedIndexChanged);
            // 
            // DtpStart
            // 
            this.DtpStart.CustomFormat = "yyyy/MM/dd";
            this.DtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpStart.Location = new System.Drawing.Point(54, 46);
            this.DtpStart.Name = "DtpStart";
            this.DtpStart.Size = new System.Drawing.Size(93, 21);
            this.DtpStart.TabIndex = 4;
            this.DtpStart.ValueChanged += new System.EventHandler(this.kryptonDateTimePicker1_ValueChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 47);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(36, 20);
            this.kryptonLabel1.TabIndex = 5;
            this.kryptonLabel1.Values.Text = "Start";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(289, 47);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(38, 20);
            this.kryptonLabel2.TabIndex = 6;
            this.kryptonLabel2.Values.Text = "Level";
            // 
            // CboLevel
            // 
            this.CboLevel.DropDownWidth = 289;
            this.CboLevel.Location = new System.Drawing.Point(333, 45);
            this.CboLevel.Name = "CboLevel";
            this.CboLevel.Size = new System.Drawing.Size(109, 21);
            this.CboLevel.TabIndex = 7;
            this.CboLevel.Text = "Semua";
            this.CboLevel.SelectedIndexChanged += new System.EventHandler(this.CboLevel_SelectedIndexChanged);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(448, 46);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(47, 20);
            this.kryptonLabel3.TabIndex = 8;
            this.kryptonLabel3.Values.Text = "Search";
            // 
            // TxtSerach
            // 
            this.TxtSerach.AllowButtonSpecToolTips = true;
            this.TxtSerach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSerach.Location = new System.Drawing.Point(501, 44);
            this.TxtSerach.Name = "TxtSerach";
            this.TxtSerach.Palette = this.kryptonPalette1;
            this.TxtSerach.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.TxtSerach.Size = new System.Drawing.Size(241, 23);
            this.TxtSerach.TabIndex = 9;
            this.TxtSerach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSerach_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuViewDetail,
            this.toolStripSeparator1,
            this.MenuSettings});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 54);
            // 
            // MenuViewDetail
            // 
            this.MenuViewDetail.Image = global::AxataPOS.LogReader.Properties.Resources.detail_12;
            this.MenuViewDetail.Name = "MenuViewDetail";
            this.MenuViewDetail.Size = new System.Drawing.Size(132, 22);
            this.MenuViewDetail.Text = "View Detail";
            this.MenuViewDetail.Click += new System.EventHandler(this.MenuViewDetail_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(129, 6);
            // 
            // MenuSettings
            // 
            this.MenuSettings.Image = global::AxataPOS.LogReader.Properties.Resources.settings_12;
            this.MenuSettings.Name = "MenuSettings";
            this.MenuSettings.Size = new System.Drawing.Size(132, 22);
            this.MenuSettings.Text = "Settings";
            this.MenuSettings.Click += new System.EventHandler(this.MenuSettings_Click);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(153, 45);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(31, 20);
            this.kryptonLabel4.TabIndex = 11;
            this.kryptonLabel4.Values.Text = "End";
            // 
            // DtpEnd
            // 
            this.DtpEnd.CustomFormat = "yyyy/MM/dd";
            this.DtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpEnd.Location = new System.Drawing.Point(190, 46);
            this.DtpEnd.Name = "DtpEnd";
            this.DtpEnd.Size = new System.Drawing.Size(93, 21);
            this.DtpEnd.TabIndex = 12;
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.DgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Level,
            this.Logger,
            this.Message,
            this.Exception});
            this.DgvData.ContextMenuStrip = this.contextMenuStrip1;
            this.DgvData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvData.Location = new System.Drawing.Point(12, 73);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvData.Size = new System.Drawing.Size(1001, 390);
            this.DgvData.TabIndex = 13;
            this.DgvData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvData_CellFormatting);
            this.DgvData.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvData_RowPostPaint);
            // 
            // lblDates
            // 
            this.lblDates.AutoSize = false;
            this.lblDates.Location = new System.Drawing.Point(278, 12);
            this.lblDates.Name = "lblDates";
            this.lblDates.Size = new System.Drawing.Size(199, 25);
            this.lblDates.TabIndex = 14;
            this.lblDates.Values.Text = "2024/01/02  s/d  2024/01/03";
            // 
            // pageControl
            // 
            this.pageControl.ActivateTooltipOnTextBox = true;
            this.pageControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pageControl.CurrentPage = 1;
            this.pageControl.Location = new System.Drawing.Point(748, 41);
            this.pageControl.Name = "pageControl";
            this.pageControl.Size = new System.Drawing.Size(265, 30);
            this.pageControl.TabIndex = 10;
            this.pageControl.TotalPages = 1;
            this.pageControl.PageChanged += new System.EventHandler<int>(this.pageControl_PageChanged);
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Time.DataPropertyName = "Time";
            dataGridViewCellStyle2.Format = "yyyy/MM/dd HH:mm:ss:fff";
            this.Time.DefaultCellStyle = dataGridViewCellStyle2;
            this.Time.HeaderText = "Timestamp";
            this.Time.MinimumWidth = 150;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 150;
            // 
            // Level
            // 
            this.Level.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Level.DataPropertyName = "Level";
            this.Level.HeaderText = "Level";
            this.Level.MinimumWidth = 75;
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            this.Level.Width = 75;
            // 
            // Logger
            // 
            this.Logger.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Logger.DataPropertyName = "Logger";
            this.Logger.HeaderText = "Logger";
            this.Logger.MinimumWidth = 175;
            this.Logger.Name = "Logger";
            this.Logger.ReadOnly = true;
            this.Logger.Width = 175;
            // 
            // Message
            // 
            this.Message.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Message.DataPropertyName = "Message";
            this.Message.FillWeight = 50F;
            this.Message.HeaderText = "Message";
            this.Message.MinimumWidth = 175;
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            // 
            // Exception
            // 
            this.Exception.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Exception.DataPropertyName = "Exception";
            this.Exception.FillWeight = 50F;
            this.Exception.HeaderText = "Exception";
            this.Exception.MinimumWidth = 175;
            this.Exception.Name = "Exception";
            this.Exception.ReadOnly = true;
            // 
            // LogViewer
            // 
            this.AllowButtonSpecToolTips = true;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 475);
            this.Controls.Add(this.lblDates);
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.DtpEnd);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.pageControl);
            this.Controls.Add(this.TxtSerach);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.CboLevel);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.DtpStart);
            this.Controls.Add(this.CboFiles);
            this.Controls.Add(this.TxtFolder);
            this.Controls.Add(this.BtnBrowseFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Header.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.StateCommon.Header.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateCommon.Header.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.StateCommon.Header.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.Text = "Log Viewer";
            this.TextExtra = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LogViewer_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.LogViewer_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.LogViewer_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.CboFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboLevel)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnBrowseFolder;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtFolder;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox CboFiles;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker DtpStart;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox CboLevel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtSerach;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuViewDetail;
        private PageControl pageControl;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker DtpEnd;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DgvData;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblDates;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuSettings;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Logger;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exception;
    }
}

