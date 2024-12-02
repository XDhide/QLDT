using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCap
    {
        public string MaNCC { get; set; }
        public string TenNhaCungCap { get; set; }
        public string SDT { get; set; }

        public NhaCungCap(string maNCC, string tenNhaCungCap, string sDT)
        {
            MaNCC = maNCC;
            TenNhaCungCap = tenNhaCungCap;
            SDT = sDT;
        }
    }
}
