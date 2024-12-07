using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class DatabaseConnect
    {
        private static string query = "Data Source=DUNGPC\\SQLEXPRESS;Initial Catalog=QLDT;Integrated Security=True;";
        public static SqlConnection Conn { get { return conn; } }

        private static SqlConnection conn = new SqlConnection(query);
        public static string OpenDatabase()
        {
            if(conn.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                }
                catch
                {
                    return "Ket Noi That Bai";
                }
                return "Ket Noi Thanh Cong";
                
            }
            return "Ket Noi Da Duoc Mo";
        }
        public static string CloseDatabase()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    conn.Close();
                    return "Dong Thanh Cong";
                }
                catch
                {
                    return "Dong That Bai";
                }

            }
            return "Ket Noi Da Duoc Dong";
        }
    }
}
