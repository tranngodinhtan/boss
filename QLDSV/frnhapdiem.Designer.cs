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
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label lANLabel;
            this.qLDSVDataSet1 = new QLDSV.QLDSVDataSet1();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLDSV.QLDSVDataSet1TableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.QLDSVDataSet1TableAdapters.TableAdapterManager();
            this.dIEMTableAdapter = new QLDSV.QLDSVDataSet1TableAdapters.DIEMTableAdapter();
            this.mONHOCTableAdapter = new QLDSV.QLDSVDataSet1TableAdapters.MONHOCTableAdapter();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lANSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbHK = new System.Windows.Forms.Label();
            this.btnbatdau = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.vMonHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.v_MonHocTableAdapter = new QLDSV.QLDSVDataSet1TableAdapters.V_MonHocTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.vLOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_LOPTableAdapter = new QLDSV.QLDSVDataSet1TableAdapters.V_LOPTableAdapter();
            this.lOPGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            tENLOPLabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lANSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMonHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vLOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(246, 20);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(53, 13);
            tENLOPLabel.TabIndex = 2;
            tENLOPLabel.Text = "TENLOP:";
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Location = new System.Drawing.Point(246, 75);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(31, 13);
            lANLabel.TabIndex = 6;
            lANLabel.Text = "LAN:";
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
            this.lANSpinEdit.Location = new System.Drawing.Point(305, 72);
            this.lANSpinEdit.Name = "lANSpinEdit";
            this.lANSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lANSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.lANSpinEdit.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 8;
            // 
            // lbHK
            // 
            this.lbHK.AutoSize = true;
            this.lbHK.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHK.Location = new System.Drawing.Point(19, 84);
            this.lbHK.Name = "lbHK";
            this.lbHK.Size = new System.Drawing.Size(55, 17);
            this.lbHK.TabIndex = 9;
            this.lbHK.Text = "Học Kỳ";
            // 
            // btnbatdau
            // 
            this.btnbatdau.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbatdau.Location = new System.Drawing.Point(249, 133);
            this.btnbatdau.Name = "btnbatdau";
            this.btnbatdau.Size = new System.Drawing.Size(75, 23);
            this.btnbatdau.TabIndex = 10;
            this.btnbatdau.Text = "Bắt Đầu";
            this.btnbatdau.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.vMonHocBindingSource;
            this.comboBox1.DisplayMember = "TENMH";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "MAMH";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên MH";
            // 
            // v_MonHocTableAdapter
            // 
            this.v_MonHocTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.vLOPBindingSource;
            this.comboBox2.DisplayMember = "TENLOP";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(305, 11);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.ValueMember = "MALOP";
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
            // lOPGridControl
            // 
            this.lOPGridControl.DataSource = this.lOPBindingSource;
            this.lOPGridControl.Location = new System.Drawing.Point(509, 20);
            this.lOPGridControl.MainView = this.gridView1;
            this.lOPGridControl.Name = "lOPGridControl";
            this.lOPGridControl.Size = new System.Drawing.Size(300, 220);
            this.lOPGridControl.TabIndex = 13;
            this.lOPGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.lOPGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // frnhapdiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 273);
            this.Controls.Add(this.lOPGridControl);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnbatdau);
            this.Controls.Add(this.lbHK);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(lANLabel);
            this.Controls.Add(this.lANSpinEdit);
            this.Controls.Add(tENLOPLabel);
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
            ((System.ComponentModel.ISupportInitialize)(this.lOPGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbHK;
        private System.Windows.Forms.Button btnbatdau;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource qLDSVDataSet1BindingSource;
        private System.Windows.Forms.BindingSource vMonHocBindingSource;
        private QLDSVDataSet1TableAdapters.V_MonHocTableAdapter v_MonHocTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource vLOPBindingSource;
        private QLDSVDataSet1TableAdapters.V_LOPTableAdapter v_LOPTableAdapter;
        private DevExpress.XtraGrid.GridControl lOPGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}