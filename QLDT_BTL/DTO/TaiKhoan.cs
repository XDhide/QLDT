using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        public string MaTaiKhoan { get; set; }
        public string MaNhanVien { get; set; }
        public string TaiKhoanName { get; set; }
        public string MatKhau { get; set; }

        public TaiKhoan(string maTaiKhoan, string maNhanVien, string taiKhoanName, string matKhau)
        {
            MaTaiKhoan = maTaiKhoan;
            MaNhanVien = maNhanVien;
            TaiKhoanName = taiKhoanName;
            MatKhau = matKhau;
        }
    }
}
