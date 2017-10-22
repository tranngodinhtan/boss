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
        public frmDN()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbK_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVDataSet.V_DS_PHANMANH);

        }

        private void cbbK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            Program.mlogin = tbTK.Text;
            Program.password = tbMK.Text;
                
            if (cbbK.SelectedIndex == 0)
            {
                Program.servername = Program.servername1;
               
            }
            else
            {
                Program.servername = Program.servername2;
                
            }
            if (Program.mlogin == "" || Program.password=="")
            {
                MessageBox.Show("Ban chua nhap tai khoan hoac mat khau");
            }
            else
            {

                if (Program.KetNoi() == 0)
                    return;
                String strLenh = "SELECT name  from sys.sysusers  where sid = SUSER_SID('" + Program.mlogin + "')";
                Program.myReader = Program.ExecSqlDataReader(strLenh, Program.connstr);
                Program.myReader.Read();


                if (Program.myReader == null)
                    return;

                Program.username = Program.myReader.GetString(0);     // Lay user name
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username của cơ sở dữ liệu", "", MessageBoxButtons.OK);
                    return;
                }
                Program.myReader.Close();

                strLenh = "sp_helpuser '" + Program.username + "'";
                // sp này trả về các fields theo thứ tự:
                //Username Groupname    LoginName    DfDBName  UserID  SID

                try
                {
                    Program.myReader = Program.ExecSqlDataReader(strLenh, Program.connstr);

                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Mã sinh viên theo Login đăng nhập chưa có quyền truy cập.", "", MessageBoxButtons.OK);
                    return;
                }

                // Lấy group name từ username
                if (Program.myReader.Read())
                    Program.mGroup = Program.myReader.GetString(1);
                else
                {
                    MessageBox.Show("Lỗi xác định quyền của user. ", "", MessageBoxButtons.OK);
                    return;
                }

                Program.myReader.Close();
                nhom = Program.mGroup;


                Form1 frMain = new Form1();
                frMain.ShowDialog();
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
    }
}
