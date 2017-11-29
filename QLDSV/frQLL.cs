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
    public partial class frQLL : Form
    {
        public frQLL()
        {
            InitializeComponent();
        }

        private void frQLL_Load(object sender, EventArgs e)
        {
            lOPTableAdapter.Connection.ConnectionString = ConnectSql.connectionstring;
            qLDSVDataSet1.EnforceConstraints = false;
            this.lOPTableAdapter.Fill(this.qLDSVDataSet1.LOP);
            this.kHOATableAdapter.Fill(this.qLDSVDataSet1.KHOA);

        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHOABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSVDataSet1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           lOPBindingSource.AddNew();
           enableEdit();
        }

        private void lOPGridControl_Click(object sender, EventArgs e)
        {

        }
        private void enableEdit()
        {
            pnEdit.Enabled = true;
            pnView.Enabled = false;
            btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled  = false;
            btnLuu.Enabled = true;
            btnPhucHoi.Enabled = true;

        }
    }
}
