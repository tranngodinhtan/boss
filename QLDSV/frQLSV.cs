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

        private void btnThem_Click(object sender, EventArgs e)
        {
            sINHVIENBindingSource.AddNew();
            enableEdit();

        }
        private void enableEdit()
        {
            pnEdit.Enabled = true;
            pnView.Enabled = false;
            btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = false;
            btnLuu.Enabled = true;
            btnPhucHoi.Enabled = true;
                 
        }

        private void reLoad()
        {
            this.sINHVIENTableAdapter.Fill(this.qLDSVDataSet1.SINHVIEN); // lấy lại dữ liệu từ sinh viên để up lại
            pnEdit.Enabled = false;
            pnView.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnTaiLai.Enabled = btnXoa.Enabled = true;
            btnPhucHoi.Enabled = true;
        }

        private void updateSource()
        {
            try
            {
                sINHVIENBindingSource.EndEdit();
                sINHVIENBindingSource.ResetCurrentItem();
                this.sINHVIENTableAdapter.Connection.ConnectionString = ConnectSql.connectionstring;
                this.sINHVIENTableAdapter.Update(this.qLDSVDataSet1);
                reLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi vui lòng thử lại" + ex.Message,"", MessageBoxButtons.OK);
                reLoad();
                return;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e) 
        {
            if (mASVTextEdit.Text.Trim() =="")// ko thể chuyển đổi từ dev.textedit sang string nên dùng cách này 
            {
                MessageBox.Show("Bạn chưa điền mã sinh viên!", "", MessageBoxButtons.OK);
                mASVTextEdit.Focus();
                return;
            }
            if (mALOPTextEdit.Text.Trim()=="")
            {
                MessageBox.Show("Bạn chưa điền mã lớp!", "", MessageBoxButtons.OK);
                mALOPTextEdit.Focus();
                return;
            }
            Form frketqua = new frKetQua();
            frketqua.StartPosition = FormStartPosition.CenterParent;
            frketqua.ShowDialog();
            if ( frketqua.DialogResult == DialogResult.OK)
            {
                updateSource();
            }
        }

        private void trimEdit()
        {
            mASVTextEdit.Text = mASVTextEdit.Text.Trim();
            mALOPTextEdit.Text = mALOPTextEdit.Text.Trim();
        }
    }
}
