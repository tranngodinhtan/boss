namespace QLDSV
{
    partial class frQLTK
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
            this.tbTDN = new System.Windows.Forms.TextBox();
            this.tbmk = new System.Windows.Forms.TextBox();
            this.tbnhaplai = new System.Windows.Forms.TextBox();
            this.lblg = new System.Windows.Forms.Label();
            this.lbmk = new System.Windows.Forms.Label();
            this.lbnhaplai = new System.Windows.Forms.Label();
            this.lbK = new System.Windows.Forms.Label();
            this.btnTTK = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnDMK = new System.Windows.Forms.Button();
            this.cbbK = new System.Windows.Forms.ComboBox();
            this.btnT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTDN
            // 
            this.tbTDN.Location = new System.Drawing.Point(206, 33);
            this.tbTDN.Name = "tbTDN";
            this.tbTDN.Size = new System.Drawing.Size(121, 20);
            this.tbTDN.TabIndex = 0;
            this.tbTDN.TextChanged += new System.EventHandler(this.tbTTK_TextChanged);
            // 
            // tbmk
            // 
            this.tbmk.Location = new System.Drawing.Point(206, 71);
            this.tbmk.Name = "tbmk";
            this.tbmk.Size = new System.Drawing.Size(121, 20);
            this.tbmk.TabIndex = 0;
            // 
            // tbnhaplai
            // 
            this.tbnhaplai.Location = new System.Drawing.Point(206, 106);
            this.tbnhaplai.Name = "tbnhaplai";
            this.tbnhaplai.Size = new System.Drawing.Size(121, 20);
            this.tbnhaplai.TabIndex = 0;
            // 
            // lblg
            // 
            this.lblg.AutoSize = true;
            this.lblg.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblg.Location = new System.Drawing.Point(12, 33);
            this.lblg.Name = "lblg";
            this.lblg.Size = new System.Drawing.Size(112, 18);
            this.lblg.TabIndex = 1;
            this.lblg.Text = "Tên Đăng Nhập";
            this.lblg.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbmk
            // 
            this.lbmk.AutoSize = true;
            this.lbmk.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmk.Location = new System.Drawing.Point(12, 71);
            this.lbmk.Name = "lbmk";
            this.lbmk.Size = new System.Drawing.Size(71, 18);
            this.lbmk.TabIndex = 1;
            this.lbmk.Text = "Mật Khẩu";
            this.lbmk.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbnhaplai
            // 
            this.lbnhaplai.AutoSize = true;
            this.lbnhaplai.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnhaplai.Location = new System.Drawing.Point(12, 106);
            this.lbnhaplai.Name = "lbnhaplai";
            this.lbnhaplai.Size = new System.Drawing.Size(132, 18);
            this.lbnhaplai.TabIndex = 1;
            this.lbnhaplai.Text = "Nhập Lại Mật Khẩu";
            this.lbnhaplai.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbK
            // 
            this.lbK.AutoSize = true;
            this.lbK.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbK.Location = new System.Drawing.Point(12, 145);
            this.lbK.Name = "lbK";
            this.lbK.Size = new System.Drawing.Size(41, 18);
            this.lbK.TabIndex = 1;
            this.lbK.Text = "Khoa";
            this.lbK.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnTTK
            // 
            this.btnTTK.Location = new System.Drawing.Point(516, 33);
            this.btnTTK.Name = "btnTTK";
            this.btnTTK.Size = new System.Drawing.Size(126, 23);
            this.btnTTK.TabIndex = 2;
            this.btnTTK.Text = "Tạo Tài Khoản";
            this.btnTTK.UseVisualStyleBackColor = true;
            this.btnTTK.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(516, 67);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(125, 23);
            this.btnX.TabIndex = 3;
            this.btnX.Text = "Xóa";
            this.btnX.UseVisualStyleBackColor = true;
            // 
            // btnDMK
            // 
            this.btnDMK.Location = new System.Drawing.Point(516, 102);
            this.btnDMK.Name = "btnDMK";
            this.btnDMK.Size = new System.Drawing.Size(124, 23);
            this.btnDMK.TabIndex = 4;
            this.btnDMK.Text = "Đổi Mật Khẩu";
            this.btnDMK.UseVisualStyleBackColor = true;
            // 
            // cbbK
            // 
            this.cbbK.FormattingEnabled = true;
            this.cbbK.Items.AddRange(new object[] {
            "PGV",
            "KHOA",
            "USER"});
            this.cbbK.Location = new System.Drawing.Point(206, 141);
            this.cbbK.Name = "cbbK";
            this.cbbK.Size = new System.Drawing.Size(121, 21);
            this.cbbK.TabIndex = 5;
            // 
            // btnT
            // 
            this.btnT.Location = new System.Drawing.Point(516, 141);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(124, 23);
            this.btnT.TabIndex = 6;
            this.btnT.Text = "Thoát";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // frQLTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 538);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.cbbK);
            this.Controls.Add(this.btnDMK);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnTTK);
            this.Controls.Add(this.lbK);
            this.Controls.Add(this.lbnhaplai);
            this.Controls.Add(this.lbmk);
            this.Controls.Add(this.lblg);
            this.Controls.Add(this.tbnhaplai);
            this.Controls.Add(this.tbmk);
            this.Controls.Add(this.tbTDN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frQLTK";
            this.Text = "frQLTK";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frQLTK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTDN;
        private System.Windows.Forms.TextBox tbmk;
        private System.Windows.Forms.TextBox tbnhaplai;
        private System.Windows.Forms.Label lblg;
        private System.Windows.Forms.Label lbmk;
        private System.Windows.Forms.Label lbnhaplai;
        private System.Windows.Forms.Label lbK;
        private System.Windows.Forms.Button btnTTK;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnDMK;
        private System.Windows.Forms.ComboBox cbbK;
        private System.Windows.Forms.Button btnT;
    }
}