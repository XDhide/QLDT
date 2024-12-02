using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string MaChucVu { get; set; }
        public NhanVien(string maNhanVien, string tenNhanVien, string sDT, string diaChi, string maChucVu)
        {
            MaNhanVien = maNhanVien;
            TenNhanVien = tenNhanVien;
            SDT = sDT;
            DiaChi = diaChi;
            MaChucVu = maChucVu;
        }
    }
}
