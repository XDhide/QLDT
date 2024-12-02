using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChucVu
    {
        public string MaChucVu { get; set; }
        public string TenChucVu { get; set; }
        public string QuyenHan { get; set; }

        public ChucVu(string maChucVu, string tenChucVu, string quyenHan)
        {
            MaChucVu = maChucVu;
            TenChucVu = tenChucVu;
            QuyenHan = quyenHan;
        }
    }
}
