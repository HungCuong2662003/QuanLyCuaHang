namespace QL_Quan_Kho_Hang
{
    partial class FrmHienLoi
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
            this.gcerr = new DevExpress.XtraGrid.GridControl();
            this.gverr = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gcerr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gverr)).BeginInit();
            this.SuspendLayout();
            // 
            // gcerr
            // 
            this.gcerr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcerr.Location = new System.Drawing.Point(0, 0);
            this.gcerr.MainView = this.gverr;
            this.gcerr.Name = "gcerr";
            this.gcerr.Size = new System.Drawing.Size(569, 378);
            this.gcerr.TabIndex = 0;
            this.gcerr.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gverr});
            // 
            // gverr
            // 
            this.gverr.GridControl = this.gcerr;
            this.gverr.Name = "gverr";
            // 
            // FrmHienLoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 378);
            this.Controls.Add(this.gcerr);
            this.Name = "FrmHienLoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHienLoi";
            this.Load += new System.EventHandler(this.FrmHienLoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcerr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gverr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcerr;
        private DevExpress.XtraGrid.Views.Grid.GridView gverr;
    }
}