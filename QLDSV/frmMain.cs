using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QLDSV
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void barStaticItem3_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            login.Caption = ConnectSql.mlogin;
            hoten.Caption = ConnectSql.mhoten;
            nhom.Caption = ConnectSql.mgroup;
            khoa.Caption = ConnectSql.khoa;
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frQLTK));
            


        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frQLSV));

        }
        private void ShowMdiChildren(Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    f.Activate();
                    return;
                }
            }
            Form form = (Form)Activator.CreateInstance(fType);
            form.MdiParent = this;
            form.Show();
        }

        private void btnQLL_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frQLL));

        }

        private void btnQLDSV_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frnhapdiem));
        }

        private void btnQLMH_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmonhoc));
        }

        private void btIn_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmIn));
        }
    }
}