using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SQLKhachHang
    {
        public string Them(KhachHang kh)
        {

            DatabaseConnect.OpenDatabase();
            string check = "SELECT MaKhachHang from KhachHang Where MaKhachHang = @MaKhachHang";
            SqlCommand cmm = new SqlCommand(check, DatabaseConnect.Conn);
            cmm.Parameters.AddWithValue("@MaKhachHang", kh.MaKhachHang);
            SqlDataReader sqlDataReader = cmm.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                return "Khach Hang Da Ton Tai";
            }


            string add = "Insert Into KhachHang Values (@MaKhachVang,@TenKhachHang,@sdt)";
            SqlCommand cm = new SqlCommand(add, DatabaseConnect.Conn);
            cm.Parameters.AddWithValue("@MaKhachVang", kh.MaKhachHang);
            cm.Parameters.AddWithValue("@TenKhachHang", kh.TenKhachHang);
            cm.Parameters.AddWithValue("@sdt", kh.SDT);

            cm.ExecuteNonQuery();
            DatabaseConnect.CloseDatabase();
            return "Them Khach Hang Thanh Cong";

        }

        public string Sua(KhachHang kh)
        {
            DatabaseConnect.OpenDatabase();
            string update = "UPDATE KhachHang SET TenKhachHang = @TenKhachHang, SDT = @sdt WHERE MaKhachHang = @MaKhachHang";
            SqlCommand cm = new SqlCommand(update, DatabaseConnect.Conn);
            cm.Parameters.AddWithValue("@MaKhachHang", kh.MaKhachHang);
            cm.Parameters.AddWithValue("@TenNhanVien", kh.TenKhachHang);
            cm.Parameters.AddWithValue("@sdt", kh.SDT);
            cm.ExecuteNonQuery();
            DatabaseConnect.CloseDatabase();

            return "Sua Thanh Cong";

        }
        public string Xoa(KhachHang kh)
        {
            DatabaseConnect.OpenDatabase();
            string deleteTaiKhoan = "DELETE FROM KhachHang WHERE MaKhachHang = @MaKhachHang";
            SqlCommand cm = new SqlCommand(deleteTaiKhoan, DatabaseConnect.Conn);
            cm.Parameters.AddWithValue("@MaNhanVien", kh.MaKhachHang);
            cm.ExecuteNonQuery();

            DatabaseConnect.CloseDatabase();
            return "Xoa Thanh Cong";

        }
        public DataTable TimKiem()
        {
            DatabaseConnect.OpenDatabase();
            string Select = "Select * from KhachHang";
            SqlCommand cm = new SqlCommand(Select, DatabaseConnect.Conn);

            DataTable dt = new DataTable();
            dt.Load(cm.ExecuteReader());
            DatabaseConnect.CloseDatabase();
            return dt;
        }
        public DataTable TimKiem(KhachHang kh)
        {
            DatabaseConnect.OpenDatabase();
            string Select = "Select * from KhachHang Where MaKhachHang = @MaKhachHang or TenKhachHang = @TenKhachHang or SDT = @sdt";
            SqlCommand cm = new SqlCommand(Select, DatabaseConnect.Conn);
            cm.Parameters.AddWithValue("@MaKhachHang", kh.MaKhachHang);
            cm.Parameters.AddWithValue("@TenKhachHang", kh.TenKhachHang);
            cm.Parameters.AddWithValue("@sdt", kh.SDT);

            DataTable dt = new DataTable();
            dt.Load(cm.ExecuteReader());
            DatabaseConnect.CloseDatabase();
            return dt;
        }
    }
}
