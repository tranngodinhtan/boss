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
        public static SqlCommand command = null;
        //public static User CurrentUsser;
        public static void Connect(String ServerName, String DatabaseName, String username, String password)
        {
            String ConnectionSting = "Data Source =" + ServerName + "; Initial Catalog =" + DatabaseName + "; Integrated Security = False; User Id = " + username + "; Password = " + password + "; MultipleActiveResultSets = True";
            try
            {
                connect = new SqlConnection(ConnectionSting);
                connect.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                connect.Close();

            }

        }
        public static DataTable GetServerName()
        {
            DataTable table = new DataTable();
            connect = new SqlConnection(@"Data Source=ACER-PC\SERVER1;Initial Catalog=QLDSV;Integrated Security=True");
            connect.Open();
            adapter = new SqlDataAdapter("select TENSERVER from dbo.V_DS_PHANMANH", connect);
            adapter.Fill(table);
            return table;
        }
    }

}
