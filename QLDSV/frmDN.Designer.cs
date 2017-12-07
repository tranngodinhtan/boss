namespace QLDSV
{
    partial class frmDN
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
            this.components = new System.ComponentModel.Container();
            this.lbK = new System.Windows.Forms.Label();
            this.lbTK = new System.Windows.Forms.Label();
            this.lbMK = new System.Windows.Forms.Label();
            this.tbTK = new System.Windows.Forms.TextBox();
            this.tbMK = new System.Windows.Forms.TextBox();
            this.btnDN = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.qLDSVDataSet = new QLDSV.QLDSVDataSet();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DS_PHANMANHTableAdapter = new QLDSV.QLDSVDataSetTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new QLDSV.QLDSVDataSetTableAdapters.TableAdapterManager();
            this.cbbK = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbK
            // 
            this.lbK.AutoSize = true;
            this.lbK.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbK.Location = new System.Drawing.Point(182, 90);
            this.lbK.Name = "lbK";
            this.lbK.Size = new System.Drawing.Size(45, 18);
            this.lbK.TabIndex = 0;
            this.lbK.Text = "Khoa";
            // 
            // lbTK
            // 
            this.lbTK.AutoSize = true;
            this.lbTK.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTK.Location = new System.Drawing.Point(182, 148);
            this.lbTK.Name = "lbTK";
            this.lbTK.Size = new System.Drawing.Size(81, 18);
            this.lbTK.TabIndex = 1;
            this.lbTK.Text = "Tài Khoản";
            // 
            // lbMK
            // 
            this.lbMK.AutoSize = true;
            this.lbMK.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMK.Location = new System.Drawing.Point(182, 208);
            this.lbMK.Name = "lbMK";
            this.lbMK.Size = new System.Drawing.Size(77, 18);
            this.lbMK.TabIndex = 2;
            this.lbMK.Text = "Mật Khẩu";
            this.lbMK.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbTK
            // 
            this.tbTK.Location = new System.Drawing.Point(286, 145);
            this.tbTK.Name = "tbTK";
            this.tbTK.Size = new System.Drawing.Size(251, 20);
            this.tbTK.TabIndex = 4;
            this.tbTK.Tag = "2";
            this.tbTK.TextChanged += new System.EventHandler(this.tbTK_TextChanged);
            // 
            // tbMK
            // 
            this.tbMK.Location = new System.Drawing.Point(286, 206);
            this.tbMK.Name = "tbMK";
            this.tbMK.Size = new System.Drawing.Size(251, 20);
            this.tbMK.TabIndex = 5;
            this.tbMK.Tag = "3";
            this.tbMK.UseSystemPasswordChar = true;
            this.tbMK.TextChanged += new System.EventHandler(this.tbMK_TextChanged);
            // 
            // btnDN
            // 
            this.btnDN.Location = new System.Drawing.Point(286, 266);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(117, 23);
            this.btnDN.TabIndex = 6;
            this.btnDN.Tag = "4";
            this.btnDN.Text = "Đăng Nhập";
            this.btnDN.UseVisualStyleBackColor = true;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // btnT
            // 
            this.btnT.Location = new System.Drawing.Point(433, 265);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(104, 23);
            this.btnT.TabIndex = 7;
            this.btnT.Tag = "5";
            this.btnT.Text = "Thoát";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // qLDSVDataSet
            // 
            this.qLDSVDataSet.DataSetName = "QLDSVDataSet";
            this.qLDSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DS_PHANMANHBindingSource
            // 
            this.v_DS_PHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.v_DS_PHANMANHBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.QLDSVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cbbK
            // 
            this.cbbK.FormattingEnabled = true;
            this.cbbK.Location = new System.Drawing.Point(286, 86);
            this.cbbK.Name = "cbbK";
            this.cbbK.Size = new System.Drawing.Size(251, 21);
            this.cbbK.TabIndex = 8;
            this.cbbK.SelectedIndexChanged += new System.EventHandler(this.cbbK_SelectedIndexChanged_1);
            // 
            // frmDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 317);
            this.Controls.Add(this.cbbK);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnDN);
            this.Controls.Add(this.tbMK);
            this.Controls.Add(this.tbTK);
            this.Controls.Add(this.lbMK);
            this.Controls.Add(this.lbTK);
            this.Controls.Add(this.lbK);
            this.Name = "frmDN";
            this.Text = "frmDN";
            this.Load += new System.EventHandler(this.frmDN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbK;
        private System.Windows.Forms.Label lbTK;
        private System.Windows.Forms.Label lbMK;
        private System.Windows.Forms.TextBox tbTK;
        private System.Windows.Forms.TextBox tbMK;
        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.Button btnT;
        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private QLDSVDataSetTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private QLDSVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbbK;
    }
}