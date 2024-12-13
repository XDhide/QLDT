using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class SqlTaiKhoan
    {
        public string Them(TaiKhoan tk)
        {
            DatabaseConnect.OpenDatabase();
            string check = "SELECT MaTaiKhoan from TaiKhoan Where MaTaiKhoan = @MaTaiKhoan";
            SqlCommand cmm = new SqlCommand(check, DatabaseConnect.Conn);
            cmm.Parameters.AddWithValue("@MaTaiKhoan", tk.MaTaiKhoan);
            SqlDataReader sqlDataReader = cmm.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                return "Tai Khoan Da Ton Tai";
            }
            string check2 = "SELECT MaNhanVien from NhanVien Where MaNhanVien = @MaNhanVien";
            SqlCommand cmmm = new SqlCommand(check2, DatabaseConnect.Conn);
            cmm.Parameters.AddWithValue("@MaNhanVien", tk.MaNhanVien);
            SqlDataReader sqlDataReader2 = cmmm.ExecuteReader();
            if (!sqlDataReader2.HasRows)
            {
                return "Nhan Vien khong Ton Tai";
            }


            string add = "Insert Into TaiKhoan Values (@MaTaiKhoan,@MaNhanVien,@TaiKhoan,@MatKhau)";
            SqlCommand cm = new SqlCommand(add, DatabaseConnect.Conn);
            cm.Parameters.AddWithValue("@MaTaiKhoan", tk.MaTaiKhoan);
            cm.Parameters.AddWithValue("@MaNhanVien", tk.MaNhanVien);
            cm.Parameters.AddWithValue("@TaiKhoan", tk.TaiKhoanName);
            cm.Parameters.AddWithValue("@MatKhau", tk.MatKhau);
            cm.ExecuteNonQuery();
            DatabaseConnect.CloseDatabase();
            return "Them Tai Khoan Thanh Cong";
        }
        public string Sua(TaiKhoan tk)
        {
            DatabaseConnect.OpenDatabase();
            string update = "UPDATE TaiKhoan SET MaNhanVien = @MaNhanVien, TaiKhoan = @TaiKhoan, MatKhau = @MatKhau WHERE MaTaiKhoan = @MaTaiKhoan";
            SqlCommand cm = new SqlCommand(update, DatabaseConnect.Conn);
            cm.Parameters.AddWithValue("@MaTaiKhoan", tk.MaTaiKhoan);
            cm.Parameters.AddWithValue("@MaNhanVien", tk.MaNhanVien);
            cm.Parameters.AddWithValue("@TaiKhoan", tk.TaiKhoanName);
            cm.Parameters.AddWithValue("@MatKhau", tk.MatKhau);
            cm.ExecuteNonQuery();
            DatabaseConnect.CloseDatabase();

            return "Sua Thanh Cong";
        }
        public string Xoa(TaiKhoan tk)
        {
            DatabaseConnect.OpenDatabase();
            string Xoa = "DELETE FROM TaiKhoan WHERE MaTaiKhoan = @MaTaiKhoan";
            SqlCommand cm = new SqlCommand(Xoa, DatabaseConnect.Conn);
            cm.Parameters.AddWithValue("@MaTaiKhoan", tk.MaTaiKhoan);
            DatabaseConnect.CloseDatabase();
            return "Xoa Thanh Cong";
        }
        public DataTable TimKiem()
        {
            DatabaseConnect.OpenDatabase();
            string Select = "Select * from TaiKhoan";
            SqlCommand cm = new SqlCommand(Select, DatabaseConnect.Conn);

            DataTable dt = new DataTable();
            dt.Load(cm.ExecuteReader());
            DatabaseConnect.CloseDatabase();
            return dt;
        }
        public DataTable TimKiem(TaiKhoan tk)
        {
            DatabaseConnect.OpenDatabase();
            string Select = "Select * from TaiKhoan Where MaTaiKhoan = @MaTaiKhoan or MaNhanVien = @MaNhanVien or TaiKhoan = @TaiKhoan or MatKhau = @MatKhau";
            SqlCommand cm = new SqlCommand(Select, DatabaseConnect.Conn);
            cm.Parameters.AddWithValue("@MaTaiKhoan", tk.MaTaiKhoan);
            cm.Parameters.AddWithValue("@MaNhanVien", tk.MaNhanVien);
            cm.Parameters.AddWithValue("@TaiKhoan", tk.TaiKhoanName);
            cm.Parameters.AddWithValue("@MatKhau", tk.MatKhau);

            DataTable dt = new DataTable();
            dt.Load(cm.ExecuteReader());
            DatabaseConnect.CloseDatabase();
            return dt;
        }
    }
}
