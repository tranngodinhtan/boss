using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace QLDSV
{
    public static class ConnectSql
    {
        public static SqlConnection connect = null;
        public static SqlDataAdapter adapter = null;
        public static SqlCommand command = new SqlCommand();
        public static string mhoten;
        public static string mgroup;
        public static string mlogin;
        public static string khoa;
        public static bool status;
        public static string connectionstring; // biến tạm chứa connectionstring
        //public static User CurrentUsser;
        public static bool Connect(String ServerName, String DatabaseName, String username, String password)
        {
            status = true;
            String ConnectionSting = "Data Source =" + ServerName + "; Initial Catalog =" + DatabaseName + "; Integrated Security = False; User Id = " + username + "; Password = " + password + "; MultipleActiveResultSets = True";
            try
            {
                connect = new SqlConnection(ConnectionSting);
                connect.Open();
                connectionstring = ConnectionSting;
            }
            catch (SqlException ex)
            {
                status = false;
                MessageBox.Show(ex.Message);
                connect.Close();

            }
            return status;
        }
        public static DataTable GetDataTable (String query)
        {
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter(query,connect);
            adapter.Fill(table);
            return table;
        }

      
    }

}
