using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class frnhapdiem : Form
    {
        public static string mamh;
        public static string malop;
        public static int hocky;
        public static int lanthi;

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
            // TODO: This line of code loads data into the 'qLDSVDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVDataSet.V_DS_PHANMANH);
            this.v_LOPTableAdapter.Fill(this.qLDSVDataSet1.V_LOP);
            this.v_MonHocTableAdapter.Fill(this.qLDSVDataSet1.V_MonHoc);
            this.dIEMTableAdapter.Fill(this.qLDSVDataSet1.DIEM);
            this.mONHOCTableAdapter.Fill(this.qLDSVDataSet1.MONHOC);
            this.lOPTableAdapter.Fill(this.qLDSVDataSet1.LOP);

        }

        private void btnbatdau_Click(object sender, EventArgs e)
        {
            diemGridView.DataSource = null;
            diemGridView.Rows.Clear();
            diemGridView.Columns.Clear();
            diemGridView.Refresh();
            mamh = cbbmh.SelectedValue.ToString();
            malop = cbblop.SelectedValue.ToString();
            hocky = (int)hOCKYSpinEdit.Value;
            lanthi = (int)lANSpinEdit.Value;
            String lenh = "SELECT MASV,HO,TEN, null as DIEM FROM SINHVIEN where MALOP = '" + malop + "'";
            DataTable table =  ConnectSql.GetDataTable(lenh);
            foreach (DataColumn dc in table.Columns)
            {
                diemGridView.Columns.Add(dc.ColumnName, dc.Caption);
            }
            foreach (DataRow dr in table.Rows)
            {
                
                lenh = String.Format("select DIEM from DIEM where MaMH='{0}' AND MaSV = '{1}' AND HocKy = {2} AND Lan = {3}", mamh, dr["MASV"].ToString(), hocky, lanthi);
                DataTable dt = ConnectSql.GetDataTable(lenh);
                object[] arr = dr.ItemArray.ToArray();
                if (dt != null && dt.Rows.Count > 0)
                {
                    arr[3] = dt.Rows[0]["DIEM"].ToString();
                }
                diemGridView.Rows.Add(arr);

            }
            diemGridView.Refresh();
        }

        public static bool isExists(string masv)
        {
            String lenh = String.Format("Select * from DIEM where MASV = '{0}' AND MAMH = '{1}' AND LAN = {2}", masv, mamh, lanthi);
            DataTable dt = ConnectSql.GetDataTable(lenh);
            return (dt != null && dt.Rows.Count > 0) ? true : false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string StrQuery;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectSql.connectionstring))
                {
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        conn.Open();
                        for (int i = 0; i < diemGridView.Rows.Count; i++)
                        {
                            if (!isExists(diemGridView.Rows[i].Cells["MASV"].Value.ToString()))
                            {
                                StrQuery = @"INSERT INTO DIEM VALUES ('"
                                + diemGridView.Rows[i].Cells["MASV"].Value + "', '"
                                + mamh + "', "
                                + lanthi + ", "
                                + diemGridView.Rows[i].Cells["DIEM"].Value +
                                ", NEWID(), "
                                + hocky + ");";
                                Console.WriteLine(StrQuery);
                                comm.CommandText = StrQuery;
                                comm.ExecuteNonQuery();
                            }
                        }

                    }
                }
               
            } catch (Exception ex)
            {
            }
        }

      

        private void cbbK_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ConnectSql.Connect(cbbK.SelectedValue.ToString(), "QLDSV", "spconnect", "12345");
            lOPTableAdapter.Connection.ConnectionString = ConnectSql.connectionstring;
            v_LOPTableAdapter.Connection.ConnectionString = v_MonHocTableAdapter.Connection.ConnectionString = ConnectSql.connectionstring;
            this.v_LOPTableAdapter.Fill(this.qLDSVDataSet1.V_LOP);
            this.v_MonHocTableAdapter.Fill(this.qLDSVDataSet1.V_MonHoc);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbblop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lANSpinEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
   
}
