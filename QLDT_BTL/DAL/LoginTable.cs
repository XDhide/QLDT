using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class LoginTable
    {
        private SqlCommand cmd;
        public string DangNhap(string username, string password)
        {
            try
            {
                DatabaseConnect.OpenDatabase();

                string sqlComman = @"
                    SELECT tk.TaiKhoan, tk.MatKhau, nv.MaChucVu
                    FROM TaiKhoan tk
                    INNER JOIN NhanVien nv ON tk.MaNhanVien = nv.MaNhanVien
                    WHERE tk.TaiKhoan = @username AND tk.MatKhau = @password";

                cmd = new SqlCommand(sqlComman, DatabaseConnect.Conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) 
                    {
                        string quyenHan = reader["MaChucVu"].ToString();

                        if (quyenHan == "ADMIN")
                        {
                            return "Dang Nhap Thanh Cong voi quyen Admin";
                        }
                        else if (quyenHan == "STAFF")
                        {
                            return "Dang Nhap Thanh Cong voi quyen Staff";
                        }
                        else
                        {
                            return "Dang Nhap khong Cong, Quyen Han khong xac dinh";
                        }
                    }
                    else
                    {
                        return "Dang Nhap That Bai";
                    }
                }
            }
            finally
            {
                DatabaseConnect.CloseDatabase();
            }
        }
    }
}
