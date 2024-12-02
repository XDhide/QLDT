using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Kho
    {
        public string MaKho { get; set; }
        public string MaSanPham { get; set; }
        public int SoLuong { get; set; }

        public Kho(string maKho, string maSanPham, int soLuong)
        {
            MaKho = maKho;
            MaSanPham = maSanPham;
            SoLuong = soLuong;
        }
    }
}
