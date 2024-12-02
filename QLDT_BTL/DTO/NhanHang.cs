using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanHang
    {
        public string MaNhanHang { get; set; }
        public string TenNhanHang { get; set; }
        public string DiaChi { get; set; }

        public NhanHang(string maNhanHang, string tenNhanHang, string diaChi)
        {
            MaNhanHang = maNhanHang;
            TenNhanHang = tenNhanHang;
            DiaChi = diaChi;
        }
    }
}
