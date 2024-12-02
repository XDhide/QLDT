using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoHanh
    {
        public string MaBaoHanh { get; set; }
        public string MaDHB { get; set; }
        public string MaNhanVien { get; set; }
        public string NgayBaoHanh { get; set; }
        public string TrangThai { get; set; }

        public BaoHanh(string maBaoHanh, string maDHB, string maNhanVien, string ngayBaoHanh, string trangThai)
        {
            MaBaoHanh = maBaoHanh;
            MaDHB = maDHB;
            MaNhanVien = maNhanVien;
            NgayBaoHanh = ngayBaoHanh;
            TrangThai = trangThai;
        }
    }
}
