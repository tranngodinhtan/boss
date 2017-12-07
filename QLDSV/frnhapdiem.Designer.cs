namespace QLDSV
{
    partial class frnhapdiem
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
            System.Windows.Forms.Label lANLabel;
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label tENLOPLabel;
            this.qLDSVDataSet1 = new QLDSV.QLDSVDataSet1();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLDSV.QLDSVDataSet1TableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.QLDSVDataSet1TableAdapters.TableAdapterManager();
            this.dIEMTableAdapter = new QLDSV.QLDSVDataSet1TableAdapters.DIEMTableAdapter();
            this.mONHOCTableAdapter = new QLDSV.QLDSVDataSet1TableAdapters.MONHOCTableAdapter();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lANSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.btnbatdau = new System.Windows.Forms.Button();
            this.vMonHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_MonHocTableAdapter = new QLDSV.QLDSVDataSet1TableAdapters.V_MonHocTableAdapter();
            this.vLOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_LOPTableAdapter = new QLDSV.QLDSVDataSet1TableAdapters.V_LOPTableAdapter();
            this.hOCKYSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.cbbmh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbblop = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.vDSPHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet = new QLDSV.QLDSVDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.diemGridView = new System.Windows.Forms.DataGridView();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.v_DS_PHANMANHTableAdapter = new QLDSV.QLDSVDataSetTableAdapters.V_DS_PHANMANHTableAdapter();
            this.cbbK = new System.Windows.Forms.ComboBox();
            this.vDSPHANMANHBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            lANLabel = new System.Windows.Forms.Label();
            hOCKYLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lANSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMonHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vLOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCKYSpinEdit.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diemGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Location = new System.Drawing.Point(696, 36);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(31, 13);
            lANLabel.TabIndex = 6;
            lANLabel.Text = "LAN:";
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Location = new System.Drawing.Point(472, 36);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(47, 13);
            hOCKYLabel.TabIndex = 13;
            hOCKYLabel.Text = "HOCKY:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(229, 32);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(53, 13);
            tENLOPLabel.TabIndex = 2;
            tENLOPLabel.Text = "TENLOP:";
            // 
            // qLDSVDataSet1
            // 
            this.qLDSVDataSet1.DataSetName = "QLDSVDataSet1";
            this.qLDSVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.qLDSVDataSet1;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = this.dIEMTableAdapter;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.QLDSVDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dIEMTableAdapter
            // 
            this.dIEMTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.qLDSVDataSet1;
            // 
            // dIEMBindingSource
            // 
            this.dIEMBindingSource.DataMember = "DIEM";
            this.dIEMBindingSource.DataSource = this.qLDSVDataSet1;
            // 
            // lANSpinEdit
            // 
            this.lANSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dIEMBindingSource, "LAN", true));
            this.lANSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.lANSpinEdit.Location = new System.Drawing.Point(755, 33);
            this.lANSpinEdit.Name = "lANSpinEdit";
            this.lANSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lANSpinEdit.Size = new System.Drawing.Size(121, 20);
            this.lANSpinEdit.TabIndex = 7;
            // 
            // btnbatdau
            // 
            this.btnbatdau.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbatdau.Location = new System.Drawing.Point(406, 80);
            this.btnbatdau.Name = "btnbatdau";
            this.btnbatdau.Size = new System.Drawing.Size(75, 23);
            this.btnbatdau.TabIndex = 10;
            this.btnbatdau.Text = "Bắt Đầu";
            this.btnbatdau.UseVisualStyleBackColor = true;
            this.btnbatdau.Click += new System.EventHandler(this.btnbatdau_Click);
            // 
            // vMonHocBindingSource
            // 
            this.vMonHocBindingSource.DataMember = "V_MonHoc";
            this.vMonHocBindingSource.DataSource = this.qLDSVDataSet1BindingSource;
            // 
            // qLDSVDataSet1BindingSource
            // 
            this.qLDSVDataSet1BindingSource.DataSource = this.qLDSVDataSet1;
            this.qLDSVDataSet1BindingSource.Position = 0;
            // 
            // v_MonHocTableAdapter
            // 
            this.v_MonHocTableAdapter.ClearBeforeFill = true;
            // 
            // vLOPBindingSource
            // 
            this.vLOPBindingSource.DataMember = "V_LOP";
            this.vLOPBindingSource.DataSource = this.qLDSVDataSet1;
            // 
            // v_LOPTableAdapter
            // 
            this.v_LOPTableAdapter.ClearBeforeFill = true;
            // 
            // hOCKYSpinEdit
            // 
            this.hOCKYSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dIEMBindingSource, "HOCKY", true));
            this.hOCKYSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.hOCKYSpinEdit.Location = new System.Drawing.Point(530, 33);
            this.hOCKYSpinEdit.Name = "hOCKYSpinEdit";
            this.hOCKYSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.hOCKYSpinEdit.Size = new System.Drawing.Size(121, 20);
            this.hOCKYSpinEdit.TabIndex = 14;
            // 
            // cbbmh
            // 
            this.cbbmh.DataSource = this.vMonHocBindingSource;
            this.cbbmh.DisplayMember = "TENMH";
            this.cbbmh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbmh.FormattingEnabled = true;
            this.cbbmh.Location = new System.Drawing.Point(63, 32);
            this.cbbmh.Name = "cbbmh";
            this.cbbmh.Size = new System.Drawing.Size(121, 21);
            this.cbbmh.TabIndex = 11;
            this.cbbmh.ValueMember = "MAMH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên MH";
            // 
            // cbblop
            // 
            this.cbblop.DataSource = this.vLOPBindingSource;
            this.cbblop.DisplayMember = "TENLOP";
            this.cbblop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbblop.FormattingEnabled = true;
            this.cbblop.Location = new System.Drawing.Point(288, 32);
            this.cbblop.Name = "cbblop";
            this.cbblop.Size = new System.Drawing.Size(121, 21);
            this.cbblop.TabIndex = 13;
            this.cbblop.ValueMember = "MALOP";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbK);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbblop);
            this.panel1.Controls.Add(hOCKYLabel);
            this.panel1.Controls.Add(tENLOPLabel);
            this.panel1.Controls.Add(this.hOCKYSpinEdit);
            this.panel1.Controls.Add(this.lANSpinEdit);
            this.panel1.Controls.Add(lANLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnbatdau);
            this.panel1.Controls.Add(this.cbbmh);
            this.panel1.Location = new System.Drawing.Point(34, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 151);
            this.panel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Khoa";
            // 
            // vDSPHANMANHBindingSource
            // 
            this.vDSPHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.vDSPHANMANHBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // qLDSVDataSet
            // 
            this.qLDSVDataSet.DataSetName = "QLDSVDataSet";
            this.qLDSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.diemGridView);
            this.panel2.Location = new System.Drawing.Point(42, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(891, 393);
            this.panel2.TabIndex = 16;
            // 
            // diemGridView
            // 
            this.diemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.diemGridView.Location = new System.Drawing.Point(33, 17);
            this.diemGridView.Name = "diemGridView";
            this.diemGridView.Size = new System.Drawing.Size(835, 341);
            this.diemGridView.TabIndex = 0;
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(289, 617);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 17;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(733, 617);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 23);
            this.btnhuy.TabIndex = 17;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // cbbK
            // 
            this.cbbK.DataSource = this.vDSPHANMANHBindingSource1;
            this.cbbK.DisplayMember = "TENKHOA";
            this.cbbK.FormattingEnabled = true;
            this.cbbK.Location = new System.Drawing.Point(63, 114);
            this.cbbK.Name = "cbbK";
            this.cbbK.Size = new System.Drawing.Size(121, 21);
            this.cbbK.TabIndex = 17;
            this.cbbK.ValueMember = "TENSERVER";
            this.cbbK.SelectedIndexChanged += new System.EventHandler(this.cbbK_SelectedIndexChanged_1);
            // 
            // vDSPHANMANHBindingSource1
            // 
            this.vDSPHANMANHBindingSource1.DataMember = "V_DS_PHANMANH";
            this.vDSPHANMANHBindingSource1.DataSource = this.qLDSVDataSet;
            // 
            // frnhapdiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 676);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frnhapdiem";
            this.Text = "frnhapdiem";
            this.Load += new System.EventHandler(this.frnhapdiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lANSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMonHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vLOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCKYSpinEdit.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diemGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QLDSVDataSet1 qLDSVDataSet1;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLDSVDataSet1TableAdapters.LOPTableAdapter lOPTableAdapter;
        private QLDSVDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private QLDSVDataSet1TableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private QLDSVDataSet1TableAdapters.DIEMTableAdapter dIEMTableAdapter;
        private System.Windows.Forms.BindingSource dIEMBindingSource;
        private DevExpress.XtraEditors.SpinEdit lANSpinEdit;
        private System.Windows.Forms.Button btnbatdau;
        private System.Windows.Forms.BindingSource qLDSVDataSet1BindingSource;
        private System.Windows.Forms.BindingSource vMonHocBindingSource;
        private QLDSVDataSet1TableAdapters.V_MonHocTableAdapter v_MonHocTableAdapter;
        private System.Windows.Forms.BindingSource vLOPBindingSource;
        private QLDSVDataSet1TableAdapters.V_LOPTableAdapter v_LOPTableAdapter;
        private DevExpress.XtraEditors.SpinEdit hOCKYSpinEdit;
        private System.Windows.Forms.ComboBox cbbmh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbblop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView diemGridView;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Label label2;
        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.BindingSource vDSPHANMANHBindingSource;
        private QLDSVDataSetTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private System.Windows.Forms.ComboBox cbbK;
        private System.Windows.Forms.BindingSource vDSPHANMANHBindingSource1;
    }
}