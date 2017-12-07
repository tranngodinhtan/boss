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
    public partial class frmonhoc : Form
    {
        int position = 0;
        public frmonhoc()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mONHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSVDataSet1);

        }

        private void frmonhoc_Load(object sender, EventArgs e)
        {
            mONHOCTableAdapter.Connection.ConnectionString = ConnectSql.connectionstring;

            qLDSVDataSet1.EnforceConstraints = false;
            this.mONHOCTableAdapter.Fill(this.qLDSVDataSet1.MONHOC);


        }
        private void updateSource()
        {
            try
            {
                mONHOCBindingSource.EndEdit();
                mONHOCBindingSource.ResetCurrentItem();
                this.mONHOCTableAdapter.Connection.ConnectionString = ConnectSql.connectionstring;
                this.mONHOCTableAdapter.Update(this.qLDSVDataSet1);
                reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi vui lòng thử lại" + ex.Message, "", MessageBoxButtons.OK);
                reload();
                return;
            }
        }
        private void reload()
        {
            this.mONHOCTableAdapter.Fill(this.qLDSVDataSet1.MONHOC);
            pnview.Enabled = true;
            pnedit.Enabled = false;
            btnluu.Enabled = btnhuy.Enabled = btnxoa.Enabled = btnsua.Enabled = btnthem.Enabled = true;
            btnphuchoi.Enabled = false;
        }
        private void trimEdit()
        {
            mAMHTextEdit.Text = mAMHTextEdit.Text.Trim();
            tENMHTextEdit.Text = tENMHTextEdit.Text.Trim();
        }
        private void enableEdit()
        {
            pnedit.Enabled = true;
            pnview.Enabled = false;
            btnsua.Enabled = btnthem.Enabled = btnxoa.Enabled = btnhuy.Enabled = false;
            btnluu.Enabled = true;
            btnphuchoi.Enabled = true;

        }

        private void btnthem_Click(object sender, EventArgs e)
        {

            mONHOCBindingSource.AddNew();
            enableEdit();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            Form frketqua = new frKetQua("Ban có muốn xóa môn học có mã " + ((DataRowView)mONHOCBindingSource[position])["MAMH"].ToString().Trim() + "không?", "Đồng ý ", "Không");
            frketqua.StartPosition = FormStartPosition.CenterParent;
            frketqua.ShowDialog();
            if (frketqua.DialogResult == DialogResult.OK)
            {
                mONHOCBindingSource.RemoveCurrent();
                updateSource();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            trimEdit();
            enableEdit();
        }

        private void btnphuchoi_Click(object sender, EventArgs e)
        {
            mONHOCBindingSource.CancelEdit();
            trimEdit();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (mAMHTextEdit.Text.Trim() == "")// ko thể chuyển đổi từ dev.textedit sang string nên dùng cách này 
            {
                MessageBox.Show("Bạn chưa điền mã môn học!", "", MessageBoxButtons.OK);
                mAMHTextEdit.Focus();
                return;
            }
            if (tENMHTextEdit.Text.Trim() == "")// ko thể chuyển đổi từ dev.textedit sang string nên dùng cách này 
            {
                MessageBox.Show("Bạn chưa điền tên môn học!", "", MessageBoxButtons.OK);
                tENMHTextEdit.Focus();
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
    }
}
