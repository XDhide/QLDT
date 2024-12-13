using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class SQLBaoHanh
    {
        public string Them(BaoHanh bh)
        {

            DatabaseConnect.OpenDatabase();
            string check = "SELECT MaBaoHanh from BaoHanh Where MaBaoHanh = @MaBaoHanh";
            SqlCommand cmm = new SqlCommand(check, DatabaseConnect.Conn);
            cmm.Parameters.AddWithValue("@MaBaoHanh", bh.MaBaoHanh);
            SqlDataReader sqlDataReader = cmm.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                return "Ma Bao Hanh Da Ton Tai";
            }
            check = "SELECT MaDHB from DonHangBan Where MaDHB = @MaDHB";
            cmm = new SqlCommand(check, DatabaseConnect.Conn);
            cmm.Parameters.AddWithValue("@MaSanPham", bh.MaDHB);
            sqlDataReader = cmm.ExecuteReader();
            if (!sqlDataReader.HasRows)
            {
                return "Khong Ton Tai Ma Don Hang Ban";
            }
            check = "SELECT MaNhanVien from NhanVien Where MaNhanVien = @MaNhanVien";
            cmm = new SqlCommand(check, DatabaseConnect.Conn);
            cmm.Parameters.AddWithValue("@MaSanPham", bh.MaNhanVien);
            sqlDataReader = cmm.ExecuteReader();
            if (!sqlDataReader.HasRows)
            {
                return "Khong Ton Tai Ma NhanVien";
            }

            string add = "Insert Into NhanVien Values (@MaBaoHanh,@MaDHB,@MaNhanVien,@NgayBaoHanh,@TrangThai,@GhiChu)";
            SqlCommand cm = new SqlCommand(add, DatabaseConnect.Conn);
            cm.Parameters.AddWithValue("@MaBaoHanh", bh.MaBaoHanh);
            cm.Parameters.AddWithValue("@MaDHB", bh.MaDHB);
            cm.Parameters.AddWithValue("@MaNhanVien", bh.MaNhanVien);
            cm.Parameters.AddWithValue("@NgayBaoHanh", bh.NgayBaoHanh);
            cm.Parameters.AddWithValue("@TrangThai", bh.TrangThai);
            cm.Parameters.AddWithValue("@GhiChu", bh.GhiChu);
            cm.ExecuteNonQuery();
            DatabaseConnect.CloseDatabase();
            return "Them Bao Hanh Thanh Cong";

        }

        public string Sua(BaoHanh bh)
        {
            DatabaseConnect.OpenDatabase();

            string check = "SELECT MaDHB from DonHangBan Where MaDHB = @MaDHB";
            SqlCommand cmm = new SqlCommand(check, DatabaseConnect.Conn);
            cmm.Parameters.AddWithValue("@MaSanPham", bh.MaDHB);
            SqlDataReader sqlDataReader = cmm.ExecuteReader();
            if (!sqlDataReader.HasRows)
            {
                return "Khong Ton Tai Ma Don Hang Ban";
            }
            check = "SELECT MaBaoHanh from BaoHanh Where MaBaoHanh = @MaBaoHanh";
             cmm = new SqlCommand(check, DatabaseConnect.Conn);
            cmm.Parameters.AddWithValue("@MaBaoHanh", bh.MaBaoHanh);
             sqlDataReader = cmm.ExecuteReader();
            if (!sqlDataReader.HasRows)
            {
                return "Ma Bao Hanh Khong Ton Tai";
            }
            check = "SELECT MaNhanVien from NhanVien Where MaNhanVien = @MaNhanVien";
            cmm = new SqlCommand(check, DatabaseConnect.Conn);
            cmm.Parameters.AddWithValue("@MaSanPham", bh.MaNhanVien);
            sqlDataReader = cmm.ExecuteReader();
            if (!sqlDataReader.HasRows)
            {
                return "Khong Ton Tai Ma NhanVien";
            }
            string update = "UPDATE BaoHanh SET  MaNhanVien = @MaNhanVien, NgayBaoHanh = @NgayBaoHanh ,TrangThai = @TrangThai  ,GhiChu = @GhiChu WHERE MaBaoHanh = @MaBaoHanh";
            SqlCommand cm = new SqlCommand(update, DatabaseConnect.Conn);
            cm.Parameters.AddWithValue("@MaBaoHanh", bh.MaBaoHanh);
            cm.Parameters.AddWithValue("@MaDHB", bh.MaDHB);
            cm.Parameters.AddWithValue("@MaNhanVien", bh.MaNhanVien);
            cm.Parameters.AddWithValue("@NgayBaoHanh", bh.NgayBaoHanh);
            cm.Parameters.AddWithValue("@TrangThai", bh.TrangThai);
            cm.Parameters.AddWithValue("@GhiChu", bh.GhiChu);
            cm.ExecuteNonQuery();
            DatabaseConnect.CloseDatabase();

            return "Sua Thanh Cong";

        }

        public string Xoa(BaoHanh bh)
        {
            DatabaseConnect.OpenDatabase();
            string delete = "DELETE FROM BaoHanh WHERE MaBaoHanh = @MaBaoHanh";
            SqlCommand cm = new SqlCommand(delete, DatabaseConnect.Conn);
            cm.Parameters.AddWithValue("@MaBaoHanh", bh.MaBaoHanh);
            cm.ExecuteNonQuery();
            
            return "Xoa Thanh Cong";

        }
        public DataTable TimKiem()
        {
            DatabaseConnect.OpenDatabase();
            string Select = "Select * from BaoHanh";
            SqlCommand cm = new SqlCommand(Select, DatabaseConnect.Conn);

            DataTable dt = new DataTable();
            dt.Load(cm.ExecuteReader());
            DatabaseConnect.CloseDatabase();
            return dt;
        }
        public DataTable TimKiem(BaoHanh bh)
        {
            DatabaseConnect.OpenDatabase();
            string Select = "Select * from NhanVien Where MaBaoHanh = @MaBaoHanh MaDHB = @MaDHB or MaNhanVien = @MaNhanVien or  NgayBaoHanh = @NgayBaoHanh or TrangThai = @TrangThai  or GhiChu = @GhiChu";
            SqlCommand cm = new SqlCommand(Select, DatabaseConnect.Conn);
            cm.Parameters.AddWithValue("@MaBaoHanh", bh.MaBaoHanh);
            cm.Parameters.AddWithValue("@MaDHB", bh.MaDHB);
            cm.Parameters.AddWithValue("@MaNhanVien", bh.MaNhanVien);
            cm.Parameters.AddWithValue("@NgayBaoHanh", bh.NgayBaoHanh);
            cm.Parameters.AddWithValue("@TrangThai", bh.TrangThai);
            cm.Parameters.AddWithValue("@GhiChu", bh.GhiChu);
            DataTable dt = new DataTable();
            dt.Load(cm.ExecuteReader());
            DatabaseConnect.CloseDatabase();
            return dt;
        }
    }
}
