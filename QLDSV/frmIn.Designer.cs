namespace QLDSV
{
    partial class frmIn
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
            System.Windows.Forms.Label mAKHLabel;
            this.qLDSVDataSet1 = new QLDSV.QLDSVDataSet1();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLDSV.QLDSVDataSet1TableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.QLDSVDataSet1TableAdapters.TableAdapterManager();
            this.cbblop = new System.Windows.Forms.ComboBox();
            this.vLOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbbK = new System.Windows.Forms.ComboBox();
            this.vDSPHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet = new QLDSV.QLDSVDataSet();
            this.v_DS_PHANMANHTableAdapter = new QLDSV.QLDSVDataSetTableAdapters.V_DS_PHANMANHTableAdapter();
            this.v_LOPTableAdapter = new QLDSV.QLDSVDataSet1TableAdapters.V_LOPTableAdapter();
            this.btnview = new System.Windows.Forms.Button();
            this.rptDSSV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            tENLOPLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vLOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(460, 33);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(53, 13);
            tENLOPLabel.TabIndex = 1;
            tENLOPLabel.Text = "TENLOP:";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(135, 33);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(37, 13);
            mAKHLabel.TabIndex = 3;
            mAKHLabel.Text = "KHOA";
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
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.QLDSVDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cbblop
            // 
            this.cbblop.DataSource = this.vLOPBindingSource;
            this.cbblop.DisplayMember = "TENLOP";
            this.cbblop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbblop.FormattingEnabled = true;
            this.cbblop.Location = new System.Drawing.Point(534, 25);
            this.cbblop.Name = "cbblop";
            this.cbblop.Size = new System.Drawing.Size(121, 21);
            this.cbblop.TabIndex = 2;
            this.cbblop.ValueMember = "TENLOP";
            // 
            // vLOPBindingSource
            // 
            this.vLOPBindingSource.DataMember = "V_LOP";
            this.vLOPBindingSource.DataSource = this.qLDSVDataSet1;
            // 
            // cbbK
            // 
            this.cbbK.DataSource = this.vDSPHANMANHBindingSource;
            this.cbbK.DisplayMember = "TENKHOA";
            this.cbbK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbK.FormattingEnabled = true;
            this.cbbK.Location = new System.Drawing.Point(201, 25);
            this.cbbK.Name = "cbbK";
            this.cbbK.Size = new System.Drawing.Size(121, 21);
            this.cbbK.TabIndex = 4;
            this.cbbK.ValueMember = "TENSERVER";
            this.cbbK.SelectedIndexChanged += new System.EventHandler(this.cbbK_SelectedIndexChanged);
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
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // v_LOPTableAdapter
            // 
            this.v_LOPTableAdapter.ClearBeforeFill = true;
            // 
            // btnview
            // 
            this.btnview.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.Location = new System.Drawing.Point(358, 59);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(75, 23);
            this.btnview.TabIndex = 5;
            this.btnview.Text = "Preview";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // rptDSSV
            // 
            this.rptDSSV.ActiveViewIndex = -1;
            this.rptDSSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptDSSV.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptDSSV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rptDSSV.Location = new System.Drawing.Point(0, 111);
            this.rptDSSV.Name = "rptDSSV";
            this.rptDSSV.Size = new System.Drawing.Size(795, 308);
            this.rptDSSV.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbK);
            this.panel1.Controls.Add(tENLOPLabel);
            this.panel1.Controls.Add(this.btnview);
            this.panel1.Controls.Add(this.cbblop);
            this.panel1.Controls.Add(mAKHLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 111);
            this.panel1.TabIndex = 7;
            // 
            // frmIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 419);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rptDSSV);
            this.Name = "frmIn";
            this.Text = "frmIn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vLOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private QLDSVDataSet1 qLDSVDataSet1;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLDSVDataSet1TableAdapters.LOPTableAdapter lOPTableAdapter;
        private QLDSVDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbblop;
        private System.Windows.Forms.ComboBox cbbK;
        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.BindingSource vDSPHANMANHBindingSource;
        private QLDSVDataSetTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private System.Windows.Forms.BindingSource vLOPBindingSource;
        private QLDSVDataSet1TableAdapters.V_LOPTableAdapter v_LOPTableAdapter;
        private System.Windows.Forms.Button btnview;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptDSSV;
        private System.Windows.Forms.Panel panel1;
    }
}