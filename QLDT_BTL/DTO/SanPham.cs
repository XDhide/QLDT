using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string MaNhanHang { get; set; }
        public float GiaBan { get; set; }

        public SanPham(string maSanPham, string tenSanPham, string maNhanHang, float giaBan)
        {
            MaSanPham = maSanPham;
            TenSanPham = tenSanPham;
            MaNhanHang = maNhanHang;
            GiaBan = giaBan;
        }
    }
}
