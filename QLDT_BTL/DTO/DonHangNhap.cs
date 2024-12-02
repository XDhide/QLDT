using System;
using System.Collections.Generic;
using System.Linq;
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

        public DonHangNhap(string maDHN, string maKho, string maNCC, string maSanPham, string ngayNhap)
        {
            MaDHN = maDHN;
            MaKho = maKho;
            MaNCC = maNCC;
            MaSanPham = maSanPham;
            NgayNhap = ngayNhap;
        }
    }
}
