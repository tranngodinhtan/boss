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
        
        int position = 0;
        public frQLL()
        {
            InitializeComponent();
        }

        private void frQLL_Load(object sender, EventArgs e)
        {
            pnEdit.Enabled = false;

            // TODO: This line of code loads data into the 'qLDSVDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVDataSet.V_DS_PHANMANH);
            lOPTableAdapter.Connection.ConnectionString = ConnectSql.connectionstring;
            this.lOPTableAdapter.Fill(this.qLDSVDataSet1.LOP);
            qLDSVDataSet1.EnforceConstraints = false;

            if (ConnectSql.mgroup != "PGV")
            {
                pnKhoa.Enabled = false;

            }
            else
            {
                cbbKhoa.SelectedIndex = ConnectSql.selectkhoa;

            }


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
            btnsua.Enabled = btnThem.Enabled = btnXoa.Enabled  = false;
            btnLuu.Enabled = true;
            btnPhucHoi.Enabled = true;

        }
        private void trimEdit()
        {
            tENLOPTextEdit.Text = tENLOPTextEdit.Text.Trim();
            mALOPTextEdit.Text = mALOPTextEdit.Text.Trim();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (tENLOPTextEdit.Text.Trim() == "")// ko thể chuyển đổi từ dev.textedit sang string nên dùng cách này 
            {
                MessageBox.Show("Bạn chưa điền tên lớp!", "", MessageBoxButtons.OK);
                tENLOPTextEdit.Focus();
                return;
            }
            if (mALOPTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền mã lớp!", "", MessageBoxButtons.OK);
                mALOPTextEdit.Focus();
                return;
            }
            Form frketqua = new frKetQua();
            frketqua.StartPosition = FormStartPosition.CenterParent;
            frketqua.ShowDialog();
            if (frketqua.DialogResult == DialogResult.OK)
            {
                updateSource();
      
            }
        }
        private void reLoad()
        {
            this.lOPTableAdapter.Fill(this.qLDSVDataSet1.LOP);
            pnView.Enabled = true;
            pnEdit.Enabled = false;
            btnLuu.Enabled = btnXoa.Enabled = btnsua.Enabled = btnThem.Enabled = true;
            btnPhucHoi.Enabled = false;
        }
        private void updateSource()
        {
            try
            {
                lOPBindingSource.EndEdit();
                lOPBindingSource.ResetCurrentItem();
                this.lOPTableAdapter.Connection.ConnectionString = ConnectSql.connectionstring;
                this.lOPTableAdapter.Update(this.qLDSVDataSet1);
                reLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi vui lòng thử lại" + ex.Message, "", MessageBoxButtons.OK);
                reLoad();
                return;
            }
        }

        private void lOPGridControl_MouseClick(object sender, MouseEventArgs e)
        {
            this.position = lOPBindingSource.Position;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Form frketQua = new frKetQua("Ban có muốn xóa sinh viên có mã " + ((DataRowView)lOPBindingSource[position])["MALOP"].ToString().Trim() + "không?", "Đồng ý ", "Không");
            frketQua.StartPosition = FormStartPosition.CenterParent;
            frketQua.ShowDialog();
            if (frketQua.DialogResult == DialogResult.OK)
            {
                lOPBindingSource.RemoveAt(lOPBindingSource.Position);
                Console.WriteLine(((DataRowView)lOPBindingSource[position])["MALOP"].ToString().Trim());
                updateSource();
            }
        }

        private void pnView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnEdit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectSql.Connect(cbbKhoa.SelectedValue.ToString(), "QLDSV", "spconnect", "12345");
            lOPTableAdapter.Connection.ConnectionString = ConnectSql.connectionstring;
            this.lOPTableAdapter.Fill(this.qLDSVDataSet1.LOP);


        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSVDataSet1);

        }

        private void mAKHLabel_Click(object sender, EventArgs e)
        {

        }

        private void mAKHTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            trimEdit();
            enableEdit();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            reLoad();
        }
    }
}
