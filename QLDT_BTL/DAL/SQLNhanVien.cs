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
    public class SQLNhanVien
    {
        public string Them(NhanVien nv)
        {
            
            DatabaseConnect.OpenDatabase();
            string check = "SELECT MaNhanVien from NhanVien Where MaNhanVien = @MaNhanVien";
            SqlCommand cmm = new SqlCommand(check, DatabaseConnect.Conn);
            cmm.Parameters.AddWithValue("@MaNhanVien", nv.MaNhanVien);
            SqlDataReader sqlDataReader = cmm.ExecuteReader();
            if (sqlDataReader.HasRows )
            {
                return "Nhan Vien Da Ton Tai";
            }


            string add = "Insert Into NhanVien Values (@MaNhanVien,@TenNhanVien,@sdt,@DiaChi,'STAFF')";
            SqlCommand cm = new SqlCommand(add,DatabaseConnect.Conn);
            cm.Parameters.AddWithValue("@MaNhanVien" , nv.MaNhanVien);
            cm.Parameters.AddWithValue("@TenNhanVien", nv.TenNhanVien);
            cm.Parameters.AddWithValue("@sdt", nv.SDT);
            cm.Parameters.AddWithValue("@DiaChi", nv.DiaChi);
            cm.ExecuteNonQuery();
            DatabaseConnect.CloseDatabase();
            return "Them Nhan Vien Thanh Cong";

        }

        public string Sua(NhanVien nv)
        {
            DatabaseConnect.OpenDatabase();
            string update = "UPDATE NhanVien SET TenNhanVien = @TenNhanVien, SDT = @sdt, DiaChi = @DiaChi WHERE MaNhanVien = @MaNhanVien";
            SqlCommand cm = new SqlCommand(update, DatabaseConnect.Conn);
            cm.Parameters.AddWithValue("@MaNhanVien", nv.MaNhanVien);
            cm.Parameters.AddWithValue("@TenNhanVien", nv.TenNhanVien);
            cm.Parameters.AddWithValue("@sdt", nv.SDT);
            cm.Parameters.AddWithValue("@DiaChi", nv.DiaChi);
            cm.ExecuteNonQuery();
            DatabaseConnect.CloseDatabase();

            return "Sua Thanh Cong";

        }
        public string Xoa(NhanVien nv)
        {
            DatabaseConnect.OpenDatabase();
            string deleteTaiKhoan = "DELETE FROM TaiKhoan WHERE MaNhanVien = @MaNhanVien";
            SqlCommand cm = new SqlCommand(deleteTaiKhoan, DatabaseConnect.Conn);
            cm.Parameters.AddWithValue("@MaNhanVien", nv.MaNhanVien);
            cm.ExecuteNonQuery();
            string update = "DELETE FROM NhanVien WHERE MaNhanVien = @MaNhanVien";
            cm = new SqlCommand(update, DatabaseConnect.Conn);
            cm.Parameters.AddWithValue("@MaNhanVien", nv.MaNhanVien);
            DatabaseConnect.CloseDatabase();
            return "Xoa Thanh Cong";
            
        }
        public DataTable TimKiem()
        {
            DatabaseConnect.OpenDatabase();
            string Select = "Select * from NhanVien";
            SqlCommand cm = new SqlCommand(Select, DatabaseConnect.Conn);
            
            DataTable dt = new DataTable();
            dt.Load(cm.ExecuteReader());
            DatabaseConnect.CloseDatabase();
            return dt;
        }
        public DataTable TimKiem(NhanVien nv)
        {
            DatabaseConnect.OpenDatabase();
            string Select = "Select * from NhanVien Where MaNhanVien = @MaNhanVien or TenNhanVien = @TenNhanVien or SDT = @sdt or DiaChi = @DiaChi or MaChucVu = @MaChucVu";
            SqlCommand cm = new SqlCommand(Select, DatabaseConnect.Conn);
            cm.Parameters.AddWithValue("@MaNhanVien", nv.MaNhanVien);
            cm.Parameters.AddWithValue("@TenNhanVien", nv.TenNhanVien);
            cm.Parameters.AddWithValue("@sdt", nv.SDT);
            cm.Parameters.AddWithValue("@DiaChi", nv.DiaChi);
            cm.Parameters.AddWithValue("@MaChucVu", nv.MaChucVu);
            DataTable dt = new DataTable();
            dt.Load(cm.ExecuteReader());
            DatabaseConnect.CloseDatabase();
            return dt;
        }
    }
}
