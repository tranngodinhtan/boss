using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLDSV
{
    public partial class frKetQua : DevExpress.XtraEditors.XtraForm
    {
        public frKetQua()
        {
            InitializeComponent();
        }
        public frKetQua(String msg)
        {

            InitializeComponent();
            lbmsg.Text = msg;
        }
        public frKetQua(String msg , String txtOK, String txtCancel)
        {
            InitializeComponent();
            lbmsg.Text = msg;
            btnOK.Text = txtOK;
            btnCancel.Text = txtCancel;

        }

        private void frKetQua_Load(object sender, EventArgs e)
        {

        }
    }
}