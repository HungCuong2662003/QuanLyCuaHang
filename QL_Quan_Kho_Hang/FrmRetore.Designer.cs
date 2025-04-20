namespace QL_Quan_Kho_Hang
{
    partial class FrmRetore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRetore));
            this.txt_dd = new System.Windows.Forms.TextBox();
            this.BTN_RETORE = new DevExpress.XtraEditors.SimpleButton();
            this.BTN_DUONGDDAN = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // txt_dd
            // 
            this.txt_dd.Location = new System.Drawing.Point(62, 89);
            this.txt_dd.Multiline = true;
            this.txt_dd.Name = "txt_dd";
            this.txt_dd.Size = new System.Drawing.Size(336, 42);
            this.txt_dd.TabIndex = 8;
            // 
            // BTN_RETORE
            // 
            this.BTN_RETORE.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_RETORE.Appearance.Options.UseFont = true;
            this.BTN_RETORE.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTN_RETORE.ImageOptions.Image")));
            this.BTN_RETORE.Location = new System.Drawing.Point(273, 163);
            this.BTN_RETORE.Name = "BTN_RETORE";
            this.BTN_RETORE.Size = new System.Drawing.Size(125, 42);
            this.BTN_RETORE.TabIndex = 7;
            this.BTN_RETORE.Text = "RETORE";
            this.BTN_RETORE.Click += new System.EventHandler(this.BTN_RETORE_Click);
            // 
            // BTN_DUONGDDAN
            // 
            this.BTN_DUONGDDAN.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DUONGDDAN.Appearance.Options.UseFont = true;
            this.BTN_DUONGDDAN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTN_DUONGDDAN.ImageOptions.Image")));
            this.BTN_DUONGDDAN.Location = new System.Drawing.Point(431, 89);
            this.BTN_DUONGDDAN.Name = "BTN_DUONGDDAN";
            this.BTN_DUONGDDAN.Size = new System.Drawing.Size(197, 42);
            this.BTN_DUONGDDAN.TabIndex = 6;
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
            this.labelControl1.Location = new System.Drawing.Point(164, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(234, 19);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "CHỌN ĐƯỜNG DẪN LƯU FILE";
            // 
            // FrmRetore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 232);
            this.Controls.Add(this.txt_dd);
            this.Controls.Add(this.BTN_RETORE);
            this.Controls.Add(this.BTN_DUONGDDAN);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmRetore";
            this.Text = "FrmRetore";
            this.Load += new System.EventHandler(this.FrmRetore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_dd;
        private DevExpress.XtraEditors.SimpleButton BTN_RETORE;
        private DevExpress.XtraEditors.SimpleButton BTN_DUONGDDAN;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}