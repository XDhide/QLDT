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
    public class SQLDonHangBan
    {
        public string Them(DonHangBan dhb)
        {

            DatabaseConnect.OpenDatabase();
            string check = "SELECT MaDHB from DonHangBan Where MaDHB = @MaDHB";
            SqlCommand cmm = new SqlCommand(check, DatabaseConnect.Conn);
            cmm.Parameters.AddWithValue("@MaDHB", dhb.MaDHB);
            SqlDataReader sqlDataReader = cmm.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                return "Don Hang Ban Da Ton Tai";
            }
            check = "SELECT MaSanPham from SanPham Where MaSanPham = @MaSanPham";
            cmm = new SqlCommand(check, DatabaseConnect.Conn);
            cmm.Parameters.AddWithValue("@MaSanPham", dhb.MaSanPham);
            sqlDataReader = cmm.ExecuteReader();
            if (!sqlDataReader.HasRows)
            {
                return "Khong Ton Tai Ma San Pham";
            }
            check = "SELECT MaKhachHang from KhachHang Where MaKhachHang = @MaKhachHang";
            cmm = new SqlCommand(check, DatabaseConnect.Conn);
            cmm.Parameters.AddWithValue("@MaKhachHang", dhb.MaKhachHang);
            sqlDataReader = cmm.ExecuteReader();
            if (!sqlDataReader.HasRows)
            {
                return "Khong Ton Tai Ma Khach Hang";
            }


            string add = "Insert Into DonHangBan Values (@MaDHB,@MaSanPham,@MaKhachHang,@SoLuong,@NgayBan,@ThanhTien,@GhiChu)";
            SqlCommand cm = new SqlCommand(add, DatabaseConnect.Conn);
            cm.Parameters.AddWithValue("@MaDHB", dhb.MaDHB);
            cm.Parameters.AddWithValue("@MaSanPham", dhb.MaSanPham);
            cm.Parameters.AddWithValue("@MaKhachHang", dhb.MaKhachHang);
            cm.Parameters.AddWithValue("@SoLuong", dhb.SoLuong);
            cm.Parameters.AddWithValue("@NgayBan", dhb.NgayBan);
            cm.Parameters.AddWithValue("@ThanhTien", dhb.ThanhTien);
            cm.Parameters.AddWithValue("@GhiChu", dhb.GhiChu);

            cm.ExecuteNonQuery();
            DatabaseConnect.CloseDatabase();
            return "Them Don Hang Thanh Cong";

        }

        public string Sua(DonHangBan  dhb)
        {
            DatabaseConnect.OpenDatabase();

            string check = "SELECT MaSanPham from SanPham Where MaSanPham = @MaSanPham";
            SqlCommand cmm = new SqlCommand(check, DatabaseConnect.Conn);
            cmm.Parameters.AddWithValue("@MaSanPham", dhb.MaSanPham);
            SqlDataReader sqlDataReader = cmm.ExecuteReader();
            if (!sqlDataReader.HasRows)
            {
                return "Khong Ton Tai Ma San Pham";
            }
            check = "SELECT MaKhachHang from KhachHang Where MaKhachHang = @MaKhachHang";
            cmm = new SqlCommand(check, DatabaseConnect.Conn);
            cmm.Parameters.AddWithValue("@MaKhachHang", dhb.MaKhachHang);
            sqlDataReader = cmm.ExecuteReader();
            if (!sqlDataReader.HasRows)
            {
                return "Khong Ton Tai Ma Khach Hang";
            }
            string update = "UPDATE DonHangBan SET MaSanPham = @MaSanPham,MaKhachHang = @MaKhachHang,SoLuong = @SoLuong,NgayBan = @NgayBan,ThanhTien = @ThanhTien,GhiChu = @GhiChu Where MaDHB = @MaDHB ";
            SqlCommand cm = new SqlCommand(update, DatabaseConnect.Conn);
            cm.Parameters.AddWithValue("@MaDHB", dhb.MaDHB);
            cm.Parameters.AddWithValue("@MaSanPham", dhb.MaSanPham);
            cm.Parameters.AddWithValue("@MaKhachHang", dhb.MaKhachHang);
            cm.Parameters.AddWithValue("@SoLuong", dhb.SoLuong);
            cm.Parameters.AddWithValue("@NgayBan", dhb.NgayBan);
            cm.Parameters.AddWithValue("@ThanhTien", dhb.ThanhTien);
            cm.Parameters.AddWithValue("@GhiChu", dhb.GhiChu);
            cm.ExecuteNonQuery();
            DatabaseConnect.CloseDatabase();

            return "Sua Thanh Cong";

        }
        public string Xoa(DonHangBan dhb)
        {
            DatabaseConnect.OpenDatabase();
            string delete = "DELETE FROM BaoHanh WHERE MaDHB = @MaDHB";
            SqlCommand cm = new SqlCommand(delete, DatabaseConnect.Conn);
            cm.Parameters.AddWithValue("@MaDHB", dhb.MaDHB);
            cm.ExecuteNonQuery();
            delete = "DELETE FROM DonHangBan WHERE MaDHB = @MaDHB";
            cm = new SqlCommand(delete, DatabaseConnect.Conn);
            cm.Parameters.AddWithValue("@MaDHB", dhb.MaDHB);
            DatabaseConnect.CloseDatabase();
            return "Xoa Thanh Cong";

        }
        public DataTable TimKiem()
        {
            DatabaseConnect.OpenDatabase();
            string Select = "Select * from DonHangBan";
            SqlCommand cm = new SqlCommand(Select, DatabaseConnect.Conn);

            DataTable dt = new DataTable();
            dt.Load(cm.ExecuteReader());
            DatabaseConnect.CloseDatabase();
            return dt;
        }
        public DataTable TimKiem(DonHangBan dhb )
        {
            DatabaseConnect.OpenDatabase();
            string Select = "Select * from DonHangBan Where MaDHB = @MaDHB or MaSanPham = @MaSanPham or MaKhachHang = @MaKhachHang or SoLuong = @SoLuong or NgayBan = @NgayBan or ThanhTien = @ThanhTien or GhiChu = @GhiChu";
            SqlCommand cm = new SqlCommand(Select, DatabaseConnect.Conn);
            cm.Parameters.AddWithValue("@MaDHB", dhb.MaDHB);
            cm.Parameters.AddWithValue("@MaSanPham", dhb.MaSanPham);
            cm.Parameters.AddWithValue("@MaKhachHang", dhb.MaKhachHang);
            cm.Parameters.AddWithValue("@SoLuong", dhb.SoLuong);
            cm.Parameters.AddWithValue("@NgayBan", dhb.NgayBan);
            cm.Parameters.AddWithValue("@ThanhTien", dhb.ThanhTien);
            cm.Parameters.AddWithValue("@GhiChu", dhb.GhiChu);
            DataTable dt = new DataTable();
            dt.Load(cm.ExecuteReader());
            DatabaseConnect.CloseDatabase();
            return dt;
        }
    }
}
