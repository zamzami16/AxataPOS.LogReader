namespace AxataPOS.App.Common
{
    partial class LoadingForm
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
            this.LblTitle = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.LblKeterangan = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.progressBar = new AxataPOS.App.Componen.AxataProgressBar();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitle.AutoSize = false;
            this.LblTitle.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.LblTitle.Location = new System.Drawing.Point(12, 13);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(523, 25);
            this.LblTitle.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.LblTitle.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.LblTitle.TabIndex = 2;
            this.LblTitle.Values.Text = "LOADING";
            // 
            // LblKeterangan
            // 
            this.LblKeterangan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblKeterangan.AutoSize = false;
            this.LblKeterangan.Location = new System.Drawing.Point(12, 71);
            this.LblKeterangan.Name = "LblKeterangan";
            this.LblKeterangan.Size = new System.Drawing.Size(523, 25);
            this.LblKeterangan.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.LblKeterangan.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.LblKeterangan.TabIndex = 3;
            this.LblKeterangan.Values.Text = "Sabar ya, sedang mengatur semua dengan rapi.";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.progressBar.ForeColor = System.Drawing.Color.BlueViolet;
            this.progressBar.Location = new System.Drawing.Point(12, 51);
            this.progressBar.MarqueeAnimationSpeed = 5;
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressColor = System.Drawing.Color.DeepSkyBlue;
            this.progressBar.Size = new System.Drawing.Size(523, 6);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 4;
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(547, 108);
            this.ControlBox = false;
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.LblKeterangan);
            this.Controls.Add(this.LblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadingForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mohon Tunggu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoadingForm_FormClosing);
            this.Load += new System.EventHandler(this.BaseLoadingForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoadingForm_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonLabel LblTitle;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel LblKeterangan;
        private Componen.AxataProgressBar progressBar;
    }
}