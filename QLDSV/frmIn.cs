using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class frmIn : Form
    {
        public frmIn()
        {
            InitializeComponent();
        }

        private void btnDSSV_Click(object sender, EventArgs e)
        {

        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSVDataSet1);

        }

        private void frmIn_Load(object sender, EventArgs e)
        {
            this.v_LOPTableAdapter.Fill(this.qLDSVDataSet1.V_LOP);
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVDataSet.V_DS_PHANMANH);
            this.lOPTableAdapter.Fill(this.qLDSVDataSet1.LOP);
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVDataSet.V_DS_PHANMANH);
            this.v_LOPTableAdapter.Fill(this.qLDSVDataSet1.V_LOP);
            this.lOPTableAdapter.Fill(this.qLDSVDataSet1.LOP);
            cbbK.SelectedIndex = 1;
            cbbK.SelectedIndex = 0;
            cbblop.SelectedIndex = 1;
            cbblop.SelectedIndex = 0;

        }

        private void lOPBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSVDataSet1);

        }

        private void cbbK_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectSql.Connect(cbbK.SelectedValue.ToString(), "QLDSV", "spconnect", "12345");
            lOPTableAdapter.Connection.ConnectionString = ConnectSql.connectionstring;
            v_LOPTableAdapter.Connection.ConnectionString = ConnectSql.connectionstring;
            this.v_LOPTableAdapter.Fill(this.qLDSVDataSet1.V_LOP);
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            rpDSSV obj = new rpDSSV();
            String strlenh = "exec sp_inDS_SV '"+cbblop.SelectedValue.ToString()+"'";
            DataTable myTable;
            myTable = ConnectSql.GetDataTable(strlenh);

            obj.SetDataSource(myTable);
            obj.SetParameterValue("LOP",cbblop.SelectedValue.ToString());
            obj.SetParameterValue("KHOA", cbbK.SelectedValue.ToString());
            rptDSSV.ReportSource = obj;
        }
    }
}
