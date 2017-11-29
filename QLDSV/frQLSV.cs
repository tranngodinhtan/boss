﻿using System;
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
        int position = 0; // 
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
            qLDSVDataSet1.EnforceConstraints = false;
            this.sINHVIENTableAdapter.Fill(this.qLDSVDataSet1.SINHVIEN);
           

        }

        private void sINHVIENGridControl_Click(object sender, EventArgs e)
        {
            this.position = sINHVIENBindingSource.Position;
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Form frketqua = new frKetQua ("Ban có muốn xóa sinh viên có mã " + ((DataRowView)sINHVIENBindingSource[position])["MASV"].ToString().Trim() + "không?","Đồng ý ","Không");
            frketqua.StartPosition = FormStartPosition.CenterParent;
            frketqua.ShowDialog();
            if (frketqua.DialogResult == DialogResult.OK)
            {
                sINHVIENBindingSource.RemoveAt(sINHVIENBindingSource.Position);
                Console.WriteLine(((DataRowView)sINHVIENBindingSource[position])["MASV"].ToString().Trim());
                updateSource();
            }
        }
        

        private void btnSua_Click(object sender, EventArgs e)
        {
            trimEdit();
            enableEdit();
        }

        private void sINHVIENGridControl_MouseClick(object sender, MouseEventArgs e)
        {
            this.position = sINHVIENBindingSource.Position;
            Console.WriteLine(sINHVIENBindingSource.Position);

        }

        private void reload()
        {
            this.sINHVIENTableAdapter.Fill(this.qLDSVDataSet1.SINHVIEN);
            pnView.Enabled = false;
            pnEdit.Enabled = true;
            btnLuu.Enabled = btnTaiLai.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
            btnPhucHoi.Enabled = false;
        }

        private void btnPhucHoi_Click(object sender, EventArgs e)
        {
            sINHVIENBindingSource.CancelEdit();
            trimEdit();
        }
    }
}
