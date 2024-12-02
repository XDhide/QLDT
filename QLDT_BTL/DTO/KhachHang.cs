using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        public string MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string SDT { get; set; }
        public KhachHang(string maKhachHang, string tenKhachHang, string sDT)
        {
            MaKhachHang = maKhachHang;
            TenKhachHang = tenKhachHang;
            SDT = sDT;
        }
    }
}
