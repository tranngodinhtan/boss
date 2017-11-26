namespace QLDSV
{
    partial class frQLSV
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
            System.Windows.Forms.Label mASVLabel;
            this.qLDSVDataSet1 = new QLDSV.QLDSVDataSet1();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new QLDSV.QLDSVDataSet1TableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager = new QLDSV.QLDSVDataSet1TableAdapters.TableAdapterManager();
            this.sINHVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.mASVTextEdit = new DevExpress.XtraEditors.TextEdit();
            mASVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASVTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(12, 33);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(40, 13);
            mASVLabel.TabIndex = 1;
            mASVLabel.Text = "MASV:";
            // 
            // qLDSVDataSet1
            // 
            this.qLDSVDataSet1.DataSetName = "QLDSVDataSet1";
            this.qLDSVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.qLDSVDataSet1;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLDSV.QLDSVDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sINHVIENGridControl
            // 
            this.sINHVIENGridControl.DataSource = this.sINHVIENBindingSource;
            this.sINHVIENGridControl.Location = new System.Drawing.Point(83, 114);
            this.sINHVIENGridControl.MainView = this.gridView1;
            this.sINHVIENGridControl.Name = "sINHVIENGridControl";
            this.sINHVIENGridControl.Size = new System.Drawing.Size(523, 154);
            this.sINHVIENGridControl.TabIndex = 1;
            this.sINHVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.sINHVIENGridControl.Click += new System.EventHandler(this.sINHVIENGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.sINHVIENGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // mASVTextEdit
            // 
            this.mASVTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sINHVIENBindingSource, "MASV", true));
            this.mASVTextEdit.Location = new System.Drawing.Point(72, 26);
            this.mASVTextEdit.Name = "mASVTextEdit";
            this.mASVTextEdit.Size = new System.Drawing.Size(100, 20);
            this.mASVTextEdit.TabIndex = 2;
            // 
            // frQLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 307);
            this.Controls.Add(mASVLabel);
            this.Controls.Add(this.mASVTextEdit);
            this.Controls.Add(this.sINHVIENGridControl);
            this.Name = "frQLSV";
            this.Text = "frQLSV";
            this.Load += new System.EventHandler(this.frQLSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASVTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLDSVDataSet1 qLDSVDataSet1;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private QLDSVDataSet1TableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private QLDSVDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sINHVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit mASVTextEdit;
    }
}