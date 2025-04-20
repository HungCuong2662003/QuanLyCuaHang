namespace QL_Quan_Kho_Hang
{
    partial class Frmbackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmbackup));
            this.txt_dd = new System.Windows.Forms.TextBox();
            this.BTN_BACKUP = new DevExpress.XtraEditors.SimpleButton();
            this.BTN_DUONGDDAN = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // txt_dd
            // 
            this.txt_dd.Location = new System.Drawing.Point(28, 70);
            this.txt_dd.Multiline = true;
            this.txt_dd.Name = "txt_dd";
            this.txt_dd.Size = new System.Drawing.Size(336, 42);
            this.txt_dd.TabIndex = 12;
            // 
            // BTN_BACKUP
            // 
            this.BTN_BACKUP.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_BACKUP.Appearance.Options.UseFont = true;
            this.BTN_BACKUP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTN_BACKUP.ImageOptions.Image")));
            this.BTN_BACKUP.Location = new System.Drawing.Point(239, 148);
            this.BTN_BACKUP.Name = "BTN_BACKUP";
            this.BTN_BACKUP.Size = new System.Drawing.Size(125, 42);
            this.BTN_BACKUP.TabIndex = 11;
            this.BTN_BACKUP.Text = "BACKUP";
            this.BTN_BACKUP.Click += new System.EventHandler(this.BTN_BACKUP_Click);
            // 
            // BTN_DUONGDDAN
            // 
            this.BTN_DUONGDDAN.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DUONGDDAN.Appearance.Options.UseFont = true;
            this.BTN_DUONGDDAN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTN_DUONGDDAN.ImageOptions.Image")));
            this.BTN_DUONGDDAN.Location = new System.Drawing.Point(397, 70);
            this.BTN_DUONGDDAN.Name = "BTN_DUONGDDAN";
            this.BTN_DUONGDDAN.Size = new System.Drawing.Size(197, 42);
            this.BTN_DUONGDDAN.TabIndex = 10;
            this.BTN_DUONGDDAN.Text = "CHỌN ĐƯỜNG DẪN";
            this.BTN_DUONGDDAN.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.BTN_DUONGDDAN.Click += new System.EventHandler(this.BTN_DUONGDDAN_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(130, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(234, 19);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "CHỌN ĐƯỜNG DẪN LƯU FILE";
            // 
            // Frmbackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 233);
            this.Controls.Add(this.txt_dd);
            this.Controls.Add(this.BTN_BACKUP);
            this.Controls.Add(this.BTN_DUONGDDAN);
            this.Controls.Add(this.labelControl1);
            this.Name = "Frmbackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmbackup";
            this.Load += new System.EventHandler(this.Frmbackup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_dd;
        private DevExpress.XtraEditors.SimpleButton BTN_BACKUP;
        private DevExpress.XtraEditors.SimpleButton BTN_DUONGDDAN;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}