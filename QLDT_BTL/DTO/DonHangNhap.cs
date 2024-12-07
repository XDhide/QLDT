using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonHangNhap
    {
        public string MaDHN { get; set; }
        public string MaKho { get; set; }
        public string MaNCC { get; set; }
        public string MaSanPham { get; set; }
        public string NgayNhap { get; set; }
        public string GhiChu { get; set; }

        public DonHangNhap(string maDHN, string maKho, string maNCC, string maSanPham, string ngayNhap, string ghichu)
        {
            MaDHN = maDHN;
            MaKho = maKho;
            MaNCC = maNCC;
            MaSanPham = maSanPham;
            NgayNhap = ngayNhap;
            GhiChu = ghichu;
        }
    }
}
