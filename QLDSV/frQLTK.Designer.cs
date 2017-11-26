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
            this.tbTTK = new System.Windows.Forms.TextBox();
            this.tbHT = new System.Windows.Forms.TextBox();
            this.tbN = new System.Windows.Forms.TextBox();
            this.tbK = new System.Windows.Forms.TextBox();
            this.lbTK = new System.Windows.Forms.Label();
            this.lbHT = new System.Windows.Forms.Label();
            this.lbN = new System.Windows.Forms.Label();
            this.lbK = new System.Windows.Forms.Label();
            this.btnTTK = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnDMK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTTK
            // 
            this.tbTTK.Location = new System.Drawing.Point(206, 33);
            this.tbTTK.Name = "tbTTK";
            this.tbTTK.Size = new System.Drawing.Size(100, 20);
            this.tbTTK.TabIndex = 0;
            // 
            // tbHT
            // 
            this.tbHT.Location = new System.Drawing.Point(206, 71);
            this.tbHT.Name = "tbHT";
            this.tbHT.Size = new System.Drawing.Size(100, 20);
            this.tbHT.TabIndex = 0;
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(206, 106);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(100, 20);
            this.tbN.TabIndex = 0;
            // 
            // tbK
            // 
            this.tbK.Location = new System.Drawing.Point(206, 145);
            this.tbK.Name = "tbK";
            this.tbK.Size = new System.Drawing.Size(100, 20);
            this.tbK.TabIndex = 0;
            // 
            // lbTK
            // 
            this.lbTK.AutoSize = true;
            this.lbTK.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTK.Location = new System.Drawing.Point(12, 33);
            this.lbTK.Name = "lbTK";
            this.lbTK.Size = new System.Drawing.Size(105, 18);
            this.lbTK.TabIndex = 1;
            this.lbTK.Text = "Tên Tài Khoản";
            this.lbTK.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbHT
            // 
            this.lbHT.AutoSize = true;
            this.lbHT.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHT.Location = new System.Drawing.Point(12, 71);
            this.lbHT.Name = "lbHT";
            this.lbHT.Size = new System.Drawing.Size(57, 18);
            this.lbHT.TabIndex = 1;
            this.lbHT.Text = "Họ Tên";
            this.lbHT.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbN
            // 
            this.lbN.AutoSize = true;
            this.lbN.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbN.Location = new System.Drawing.Point(12, 106);
            this.lbN.Name = "lbN";
            this.lbN.Size = new System.Drawing.Size(47, 18);
            this.lbN.TabIndex = 1;
            this.lbN.Text = "Nhóm";
            this.lbN.Click += new System.EventHandler(this.label1_Click);
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
            // frQLTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 538);
            this.Controls.Add(this.btnDMK);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnTTK);
            this.Controls.Add(this.lbK);
            this.Controls.Add(this.lbN);
            this.Controls.Add(this.lbHT);
            this.Controls.Add(this.lbTK);
            this.Controls.Add(this.tbK);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.tbHT);
            this.Controls.Add(this.tbTTK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frQLTK";
            this.Text = "frQLTK";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frQLTK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTTK;
        private System.Windows.Forms.TextBox tbHT;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.TextBox tbK;
        private System.Windows.Forms.Label lbTK;
        private System.Windows.Forms.Label lbHT;
        private System.Windows.Forms.Label lbN;
        private System.Windows.Forms.Label lbK;
        private System.Windows.Forms.Button btnTTK;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnDMK;
    }
}