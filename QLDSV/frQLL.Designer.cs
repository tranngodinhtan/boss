namespace QLDSV
{
    partial class frQLL
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
            this.lbML = new System.Windows.Forms.Label();
            this.lbTL = new System.Windows.Forms.Label();
            this.tbML = new System.Windows.Forms.TextBox();
            this.tbTL = new System.Windows.Forms.TextBox();
            this.lbK = new System.Windows.Forms.Label();
            this.tbK = new System.Windows.Forms.TextBox();
            this.btnT = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbML
            // 
            this.lbML.AutoSize = true;
            this.lbML.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbML.Location = new System.Drawing.Point(39, 94);
            this.lbML.Name = "lbML";
            this.lbML.Size = new System.Drawing.Size(56, 18);
            this.lbML.TabIndex = 0;
            this.lbML.Text = "Mã Lớp";
            // 
            // lbTL
            // 
            this.lbTL.AutoSize = true;
            this.lbTL.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTL.Location = new System.Drawing.Point(39, 136);
            this.lbTL.Name = "lbTL";
            this.lbTL.Size = new System.Drawing.Size(62, 18);
            this.lbTL.TabIndex = 0;
            this.lbTL.Text = "Tên Lớp";
            // 
            // tbML
            // 
            this.tbML.Location = new System.Drawing.Point(132, 91);
            this.tbML.Name = "tbML";
            this.tbML.Size = new System.Drawing.Size(151, 20);
            this.tbML.TabIndex = 1;
            // 
            // tbTL
            // 
            this.tbTL.Location = new System.Drawing.Point(132, 136);
            this.tbTL.Name = "tbTL";
            this.tbTL.Size = new System.Drawing.Size(151, 20);
            this.tbTL.TabIndex = 1;
            // 
            // lbK
            // 
            this.lbK.AutoSize = true;
            this.lbK.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbK.Location = new System.Drawing.Point(247, 13);
            this.lbK.Name = "lbK";
            this.lbK.Size = new System.Drawing.Size(41, 18);
            this.lbK.TabIndex = 2;
            this.lbK.Text = "Khoa";
            // 
            // tbK
            // 
            this.tbK.Location = new System.Drawing.Point(327, 10);
            this.tbK.Name = "tbK";
            this.tbK.Size = new System.Drawing.Size(217, 20);
            this.tbK.TabIndex = 3;
            // 
            // btnT
            // 
            this.btnT.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT.Location = new System.Drawing.Point(431, 93);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(75, 23);
            this.btnT.TabIndex = 4;
            this.btnT.Text = "Thêm";
            this.btnT.UseVisualStyleBackColor = true;
            // 
            // btnS
            // 
            this.btnS.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.Location = new System.Drawing.Point(431, 133);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(75, 23);
            this.btnS.TabIndex = 4;
            this.btnS.Text = "Sửa";
            this.btnS.UseVisualStyleBackColor = true;
            // 
            // btnX
            // 
            this.btnX.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Location = new System.Drawing.Point(552, 94);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(75, 23);
            this.btnX.TabIndex = 4;
            this.btnX.Text = "Xóa";
            this.btnX.UseVisualStyleBackColor = true;
            // 
            // btnG
            // 
            this.btnG.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnG.Location = new System.Drawing.Point(552, 131);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(75, 23);
            this.btnG.TabIndex = 4;
            this.btnG.Text = "Ghi";
            this.btnG.UseVisualStyleBackColor = true;
            // 
            // frQLL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 283);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.tbK);
            this.Controls.Add(this.lbK);
            this.Controls.Add(this.tbTL);
            this.Controls.Add(this.tbML);
            this.Controls.Add(this.lbTL);
            this.Controls.Add(this.lbML);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frQLL";
            this.Text = "frQLL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frQLL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbML;
        private System.Windows.Forms.Label lbTL;
        private System.Windows.Forms.TextBox tbML;
        private System.Windows.Forms.TextBox tbTL;
        private System.Windows.Forms.Label lbK;
        private System.Windows.Forms.TextBox tbK;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnG;
    }
}