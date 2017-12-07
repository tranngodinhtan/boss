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

    public partial class frmDN : Form
    {
        
        public static string nhom = "";
        public static int cbK = 0;
        DataTable table;
        public frmDN()
        {
            InitializeComponent();
            ConnectSql.Connect(@"ACER-PC", "QLDSV", "sa", "12345");
            table = ConnectSql.GetDataTable("select * from V_DS_PHANMANH");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbK_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDN_Load(object sender, EventArgs e)
        {
            cbbK.DataSource = table; // tao datasourece
            cbbK.DisplayMember = table.Columns[0].ToString();// lay hang 1 cua bang khoa
            cbbK.ValueMember = table.Columns[1].ToString();// gan gia tri server cho khoa

        }

        private void cbbK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbTK.Text) || (String.IsNullOrWhiteSpace(tbMK.Text)))
            {
                MessageBox.Show("Moi ban nhap day du thong tin");
                
            }
            else
            {
                String ServerName = cbbK.SelectedValue.ToString();
                ConnectSql.servername = ServerName;
                if (ConnectSql.Connect(@ServerName, "QLDSV", tbTK.Text, tbMK.Text) == true)
                {
                    ConnectSql.tk = tbTK.Text;
                    ConnectSql.mk = tbMK.Text;
                    DataTable tb = ConnectSql.GetDataTable(String.Format("exec  [dbo].[SP_DANGNHAP] '{0}'", tbTK.Text));// 
                    ConnectSql.mlogin = tb.Rows[0][0].ToString();
                    ConnectSql.mhoten = tb.Rows[0][1].ToString();
                    ConnectSql.mgroup = tb.Rows[0][2].ToString();
                    ConnectSql.khoa = table.Rows[cbbK.SelectedIndex][0].ToString();
                    ConnectSql.selectkhoa = cbbK.SelectedIndex;
                    frmMain frmain = new frmMain();
                    this.Hide();
                    frmain.ShowDialog();
                    this.Show();
                   
                }
            }
        }
        private void btnT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Đã Chắc Chắn Muốn Thoát ?? ", "Thông Báo !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void tbTK_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMK_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbK_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
