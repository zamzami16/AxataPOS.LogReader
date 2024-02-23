using ComponentFactory.Krypton.Toolkit;
using System.Diagnostics;

namespace AxataPOS.LogReader
{
    public partial class SettingsForm : KryptonForm
    {
        private Settings _settings;

        public SettingsForm()
        {
            InitializeComponent();
            _settings = Settings.Instance;
            this.numPageSize.Value = _settings.BatchSize;
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            _settings = CreateSettings().Save();
            KryptonMessageBox.Show("Berhasil menyimpan settings", "Simpan", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }

        private Settings CreateSettings()
        {
            int batchSize = (int)numPageSize.Value;

            return new Settings { BatchSize = batchSize };
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            var current = CreateSettings();
            if (_settings.Equals(current))
            {
                this.Close();
                return;
            }

            var dlg = KryptonMessageBox.Show("Apakah ingin menyimpan perubahan?", "Simpan", System.Windows.Forms.MessageBoxButtons.YesNoCancel, System.Windows.Forms.MessageBoxIcon.Question);

            if (dlg is System.Windows.Forms.DialogResult.Yes)
            {
                btnSave_Click(sender, e);
            }
            else if (dlg is System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            this.Close();
        }

        private void lblMoreSettings_LinkClicked(object sender, System.EventArgs e)
        {
            // visit this link https://github.com/zamzami16/AxataPOS.LogReader/issues/new
            Process.Start("https://github.com/zamzami16/AxataPOS.LogReader/issues/new");
            lblMoreSettings.LinkVisited = true;
        }
    }
}
