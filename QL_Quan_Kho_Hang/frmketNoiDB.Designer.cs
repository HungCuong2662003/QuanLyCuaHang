namespace QL_Quan_Kho_Hang
{
    partial class frmketNoiDB
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Cbb_Database = new System.Windows.Forms.ComboBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_KT = new System.Windows.Forms.Button();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_server = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_docfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_docfile);
            this.groupControl1.Controls.Add(this.Cbb_Database);
            this.groupControl1.Controls.Add(this.btn_thoat);
            this.groupControl1.Controls.Add(this.btn_Luu);
            this.groupControl1.Controls.Add(this.btn_KT);
            this.groupControl1.Controls.Add(this.txt_user);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txt_pass);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txt_server);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(419, 244);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin kết nối";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // Cbb_Database
            // 
            this.Cbb_Database.FormattingEnabled = true;
            this.Cbb_Database.Location = new System.Drawing.Point(191, 147);
            this.Cbb_Database.Name = "Cbb_Database";
            this.Cbb_Database.Size = new System.Drawing.Size(173, 21);
            this.Cbb_Database.TabIndex = 13;
            this.Cbb_Database.SelectedIndexChanged += new System.EventHandler(this.Cbb_Database_SelectedIndexChanged_1);
            this.Cbb_Database.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbb_Database_MouseClick);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(303, 194);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 31);
            this.btn_thoat.TabIndex = 11;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(209, 194);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 31);
            this.btn_Luu.TabIndex = 10;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_KT
            // 
            this.btn_KT.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KT.Location = new System.Drawing.Point(22, 194);
            this.btn_KT.Name = "btn_KT";
            this.btn_KT.Size = new System.Drawing.Size(75, 31);
            this.btn_KT.TabIndex = 8;
            this.btn_KT.Text = "Kiểm tra";
            this.btn_KT.UseVisualStyleBackColor = true;
            this.btn_KT.Click += new System.EventHandler(this.btn_KT_Click);
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(191, 83);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(173, 21);
            this.txt_user.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Database";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(191, 114);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(173, 21);
            this.txt_pass.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pass";
            // 
            // txt_server
            // 
            this.txt_server.Location = new System.Drawing.Point(191, 49);
            this.txt_server.Name = "txt_server";
            this.txt_server.Size = new System.Drawing.Size(173, 21);
            this.txt_server.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // btn_docfile
            // 
            this.btn_docfile.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_docfile.Location = new System.Drawing.Point(113, 194);
            this.btn_docfile.Name = "btn_docfile";
            this.btn_docfile.Size = new System.Drawing.Size(75, 31);
            this.btn_docfile.TabIndex = 14;
            this.btn_docfile.Text = "Đọc file";
            this.btn_docfile.UseVisualStyleBackColor = true;
            this.btn_docfile.Click += new System.EventHandler(this.btn_docfile_Click_1);
            // 
            // frmketNoiDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 268);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmketNoiDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết nối cơ sở dữ liệu";
            this.Load += new System.EventHandler(this.frmketNoiDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_server;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_KT;
        private System.Windows.Forms.ComboBox Cbb_Database;
        private System.Windows.Forms.Button btn_docfile;
    }
}