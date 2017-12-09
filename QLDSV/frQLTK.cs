using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLDSV
{
    public partial class frQLTK : Form
    {
        public frQLTK()
        {
            InitializeComponent();
            if (ConnectSql.mgroup == "KHOA")
            {
                cbbK.Items.RemoveAt(0);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frQLTK_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace (tbTDN.Text)|| String.IsNullOrWhiteSpace(tbmk.Text))
                {
                MessageBox.Show("Bạn chưa nhập đủ thông tin");
                }
            else if(tbmk.Text != tbnhaplai.Text)
                {
                MessageBox.Show("Mật khẩu không khớp");
                }
            else
            {
                try
                {
                    ConnectSql.GetDataTable(String.Format("exec SP_taoTK '{0}','{1}','{2}','{3}'", tbTDN.Text, tbmk.Text, tbTDN.Text, cbbK.SelectedItem.ToString()));
                    MessageBox.Show("Tạo tài khoản thành công");
                }catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }    

                    }

        private void tbTTK_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnT_Click(object sender, EventArgs e)
        {
            
        }
    }
}
