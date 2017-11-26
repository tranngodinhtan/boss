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
    public partial class frQLSV : Form
    {
        public frQLSV()
        {
            InitializeComponent();
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sINHVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSVDataSet1);

        }

        private void frQLSV_Load(object sender, EventArgs e)
        {
            sINHVIENTableAdapter.Connection.ConnectionString = ConnectSql.connectionstring;
            this.sINHVIENTableAdapter.Fill(this.qLDSVDataSet1.SINHVIEN);

        }

        private void sINHVIENGridControl_Click(object sender, EventArgs e)
        {

        }

        private void tENTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void tENLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
