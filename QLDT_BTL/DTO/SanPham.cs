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
        public string NhaCungCap { get; set; }
        public float GiaBan { get; set; }
        public string GhiChu {  get; set; }

        public SanPham(string maSanPham, string tenSanPham, string maNhanHang, float giaBan, string ghiChu)
        {
            MaSanPham = maSanPham;
            TenSanPham = tenSanPham;
            NhaCungCap = maNhanHang;
            GiaBan = giaBan;
            GhiChu = ghiChu;
        }
    }
}
