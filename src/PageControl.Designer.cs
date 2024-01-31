namespace AxataPOS.LogReader
{
    partial class PageControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPreviousPage = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtCurrentPage = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtTotalPage = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnNextPage = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Location = new System.Drawing.Point(3, 5);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(19, 20);
            this.btnPreviousPage.TabIndex = 0;
            this.btnPreviousPage.Values.Image = global::AxataPOS.LogReader.Properties.Resources.icons8_previous_12;
            this.btnPreviousPage.Values.Text = "";
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // txtCurrentPage
            // 
            this.txtCurrentPage.Location = new System.Drawing.Point(28, 4);
            this.txtCurrentPage.Name = "txtCurrentPage";
            this.txtCurrentPage.Size = new System.Drawing.Size(66, 23);
            this.txtCurrentPage.TabIndex = 1;
            this.txtCurrentPage.WordWrap = false;
            this.txtCurrentPage.TextChanged += new System.EventHandler(this.txtCurrentPage_TextChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(100, 5);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(15, 20);
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "/";
            // 
            // txtTotalPage
            // 
            this.txtTotalPage.Location = new System.Drawing.Point(121, 4);
            this.txtTotalPage.Name = "txtTotalPage";
            this.txtTotalPage.ReadOnly = true;
            this.txtTotalPage.Size = new System.Drawing.Size(63, 23);
            this.txtTotalPage.TabIndex = 3;
            this.txtTotalPage.WordWrap = false;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(190, 5);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(19, 20);
            this.btnNextPage.TabIndex = 4;
            this.btnNextPage.Values.Image = global::AxataPOS.LogReader.Properties.Resources.icons8_next_12;
            this.btnNextPage.Values.Text = "";
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // PageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.txtTotalPage);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.txtCurrentPage);
            this.Controls.Add(this.btnPreviousPage);
            this.Name = "PageControl";
            this.Size = new System.Drawing.Size(212, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPreviousPage;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCurrentPage;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTotalPage;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNextPage;
    }
}
