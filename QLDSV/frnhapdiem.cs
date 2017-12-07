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
    public partial class frnhapdiem : Form
    {
        public frnhapdiem()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSVDataSet1);

        }

        private void frnhapdiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet1.V_LOP' table. You can move, or remove it, as needed.
            this.v_LOPTableAdapter.Fill(this.qLDSVDataSet1.V_LOP);
            // TODO: This line of code loads data into the 'qLDSVDataSet1.V_MonHoc' table. You can move, or remove it, as needed.
            this.v_MonHocTableAdapter.Fill(this.qLDSVDataSet1.V_MonHoc);
            // TODO: This line of code loads data into the 'qLDSVDataSet1.DIEM' table. You can move, or remove it, as needed.
            this.dIEMTableAdapter.Fill(this.qLDSVDataSet1.DIEM);
            // TODO: This line of code loads data into the 'qLDSVDataSet1.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.qLDSVDataSet1.MONHOC);
            // TODO: This line of code loads data into the 'qLDSVDataSet1.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLDSVDataSet1.LOP);

        }
    }
}
