namespace QL_Quan_Kho_Hang
{
    partial class FrmBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaoCao));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.List_menu = new DevExpress.XtraEditors.ImageListBoxControl();
            this.btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_th = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.List_menu)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.List_menu);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.btn_thoat);
            this.splitContainerControl1.Panel2.Controls.Add(this.btn_th);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(984, 598);
            this.splitContainerControl1.SplitterPosition = 366;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // List_menu
            // 
            this.List_menu.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List_menu.Appearance.Options.UseFont = true;
            this.List_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.List_menu.Location = new System.Drawing.Point(0, 0);
            this.List_menu.Name = "List_menu";
            this.List_menu.Size = new System.Drawing.Size(366, 598);
            this.List_menu.TabIndex = 0;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Appearance.Options.UseFont = true;
            this.btn_thoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.ImageOptions.Image")));
            this.btn_thoat.Location = new System.Drawing.Point(308, 457);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(136, 41);
            this.btn_thoat.TabIndex = 1;
            this.btn_thoat.Text = "Thoát ";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_th
            // 
            this.btn_th.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_th.Appearance.Options.UseFont = true;
            this.btn_th.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_th.ImageOptions.Image")));
            this.btn_th.Location = new System.Drawing.Point(137, 457);
            this.btn_th.Name = "btn_th";
            this.btn_th.Size = new System.Drawing.Size(136, 41);
            this.btn_th.TabIndex = 0;
            this.btn_th.Text = "Thực hiện";
            this.btn_th.Click += new System.EventHandler(this.btn_th_Click);
            // 
            // FrmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(984, 598);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmBaoCao";
            this.Text = "FrmBaoCao";
            this.Load += new System.EventHandler(this.FrmBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.List_menu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.ImageListBoxControl List_menu;
        private DevExpress.XtraEditors.SimpleButton btn_th;
        private DevExpress.XtraEditors.SimpleButton btn_thoat;
    }
}