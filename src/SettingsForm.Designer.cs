namespace AxataPOS.LogReader
{
    partial class SettingsForm
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
            this.lblPageSize = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.numPageSize = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.btnExit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblMoreSettings = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.SuspendLayout();
            // 
            // lblPageSize
            // 
            this.lblPageSize.Location = new System.Drawing.Point(12, 12);
            this.lblPageSize.Name = "lblPageSize";
            this.lblPageSize.Size = new System.Drawing.Size(70, 20);
            this.lblPageSize.TabIndex = 0;
            this.lblPageSize.Values.ExtraText = ":";
            this.lblPageSize.Values.Text = "Page Size";
            // 
            // numPageSize
            // 
            this.numPageSize.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numPageSize.Location = new System.Drawing.Point(88, 12);
            this.numPageSize.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numPageSize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPageSize.Name = "numPageSize";
            this.numPageSize.Size = new System.Drawing.Size(89, 22);
            this.numPageSize.TabIndex = 1;
            this.numPageSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnExit
            // 
            this.btnExit.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.btnExit.Location = new System.Drawing.Point(458, 262);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 25);
            this.btnExit.TabIndex = 2;
            this.btnExit.Values.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(362, 262);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 25);
            this.btnSave.TabIndex = 3;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblMoreSettings
            // 
            this.lblMoreSettings.LinkBehavior = ComponentFactory.Krypton.Toolkit.KryptonLinkBehavior.HoverUnderline;
            this.lblMoreSettings.Location = new System.Drawing.Point(12, 262);
            this.lblMoreSettings.Name = "lblMoreSettings";
            this.lblMoreSettings.Size = new System.Drawing.Size(285, 20);
            this.lblMoreSettings.TabIndex = 4;
            this.lblMoreSettings.Values.Text = "For more settings, please open an issue on GitHub";
            this.lblMoreSettings.LinkClicked += new System.EventHandler(this.lblMoreSettings_LinkClicked);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 299);
            this.Controls.Add(this.lblMoreSettings);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.numPageSize);
            this.Controls.Add(this.lblPageSize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblPageSize;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown numPageSize;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lblMoreSettings;
    }
}