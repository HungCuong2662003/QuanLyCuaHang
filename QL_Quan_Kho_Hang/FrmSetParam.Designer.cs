namespace QL_Quan_Kho_Hang
{
    partial class FrmSetParam
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_luu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.cbo_congty = new System.Windows.Forms.ComboBox();
            this.cbo_dvi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(54, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(143, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Công ty - Chi nhánh";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(54, 109);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(128, 18);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Đơn vị trực thuộc";
            // 
            // btn_luu
            // 
            this.btn_luu.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Appearance.Options.UseFont = true;
            this.btn_luu.Location = new System.Drawing.Point(239, 183);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 23);
            this.btn_luu.TabIndex = 4;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Appearance.Options.UseFont = true;
            this.btn_thoat.Location = new System.Drawing.Point(349, 183);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 5;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // cbo_congty
            // 
            this.cbo_congty.FormattingEnabled = true;
            this.cbo_congty.Location = new System.Drawing.Point(222, 55);
            this.cbo_congty.Name = "cbo_congty";
            this.cbo_congty.Size = new System.Drawing.Size(241, 21);
            this.cbo_congty.TabIndex = 6;
            // 
            // cbo_dvi
            // 
            this.cbo_dvi.FormattingEnabled = true;
            this.cbo_dvi.Location = new System.Drawing.Point(222, 106);
            this.cbo_dvi.Name = "cbo_dvi";
            this.cbo_dvi.Size = new System.Drawing.Size(241, 21);
            this.cbo_dvi.TabIndex = 7;
            this.cbo_dvi.SelectedIndexChanged += new System.EventHandler(this.cbo_dvi_SelectedIndexChanged);
            // 
            // FrmSetParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 281);
            this.Controls.Add(this.cbo_dvi);
            this.Controls.Add(this.cbo_congty);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmSetParam";
            this.Text = "FrmSetParam";
            this.Load += new System.EventHandler(this.FrmSetParam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_luu;
        private DevExpress.XtraEditors.SimpleButton btn_thoat;
        private System.Windows.Forms.ComboBox cbo_congty;
        private System.Windows.Forms.ComboBox cbo_dvi;
    }
}