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
            this.components = new System.ComponentModel.Container();
            this.btnPreviousPage = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtCurrentPage = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtTotalPage = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnNextPage = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnFirstPage = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnLastPage = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Location = new System.Drawing.Point(29, 5);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(19, 20);
            this.btnPreviousPage.TabIndex = 0;
            this.toolTip.SetToolTip(this.btnPreviousPage, "Previous Page");
            this.btnPreviousPage.Values.Image = global::AxataPOS.LogReader.Properties.Resources.icons8_previous_12;
            this.btnPreviousPage.Values.Text = "";
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // txtCurrentPage
            // 
            this.txtCurrentPage.Location = new System.Drawing.Point(54, 4);
            this.txtCurrentPage.Name = "txtCurrentPage";
            this.txtCurrentPage.Size = new System.Drawing.Size(66, 23);
            this.txtCurrentPage.TabIndex = 1;
            this.txtCurrentPage.WordWrap = false;
            this.txtCurrentPage.Enter += new System.EventHandler(this.txtCurrentPage_Enter);
            this.txtCurrentPage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCurrentPage_KeyDown);
            this.txtCurrentPage.Leave += new System.EventHandler(this.txtCurrentPage_Leave);
            this.txtCurrentPage.MouseEnter += new System.EventHandler(this.txtCurrentPage_MouseEnter);
            this.txtCurrentPage.MouseHover += new System.EventHandler(this.txtCurrentPage_MouseHover);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(126, 7);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(15, 20);
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "/";
            // 
            // txtTotalPage
            // 
            this.txtTotalPage.Location = new System.Drawing.Point(147, 4);
            this.txtTotalPage.Name = "txtTotalPage";
            this.txtTotalPage.ReadOnly = true;
            this.txtTotalPage.Size = new System.Drawing.Size(63, 23);
            this.txtTotalPage.TabIndex = 3;
            this.txtTotalPage.WordWrap = false;
            this.txtTotalPage.MouseEnter += new System.EventHandler(this.txtTotalPage_MouseEnter);
            this.txtTotalPage.MouseHover += new System.EventHandler(this.txtTotalPage_MouseHover);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(216, 5);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(19, 20);
            this.btnNextPage.TabIndex = 4;
            this.toolTip.SetToolTip(this.btnNextPage, "Next Page");
            this.btnNextPage.Values.Image = global::AxataPOS.LogReader.Properties.Resources.icons8_next_12;
            this.btnNextPage.Values.Text = "";
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Location = new System.Drawing.Point(4, 5);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(19, 20);
            this.btnFirstPage.TabIndex = 5;
            this.toolTip.SetToolTip(this.btnFirstPage, "First Page");
            this.btnFirstPage.Values.Image = global::AxataPOS.LogReader.Properties.Resources.first_12;
            this.btnFirstPage.Values.Text = "";
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.Location = new System.Drawing.Point(241, 5);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(19, 20);
            this.btnLastPage.TabIndex = 6;
            this.toolTip.SetToolTip(this.btnLastPage, "Last Page");
            this.btnLastPage.Values.Image = global::AxataPOS.LogReader.Properties.Resources.last_12;
            this.btnLastPage.Values.Text = "";
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 1000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 100;
            // 
            // PageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.btnFirstPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.txtTotalPage);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.txtCurrentPage);
            this.Controls.Add(this.btnPreviousPage);
            this.Name = "PageControl";
            this.Size = new System.Drawing.Size(265, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPreviousPage;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCurrentPage;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTotalPage;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNextPage;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnFirstPage;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLastPage;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
