using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonHangBan
    {
        public string MaDHB { get; set; }
        public string MaSanPham { get; set; }
        public string MaKhachHang { get; set; }
        public int SoLuong { get; set; }
        public string NgayBan { get; set; }
        public string ThanhTien { get; set; }

        public DonHangBan(string maDHB, string maSanPham, string maKhachHang, int soLuong, string ngayBan, string thanhTien)
        {
            MaDHB = maDHB;
            MaSanPham = maSanPham;
            MaKhachHang = maKhachHang;
            SoLuong = soLuong;
            NgayBan = ngayBan;
            ThanhTien = thanhTien;
        }
    }
}
