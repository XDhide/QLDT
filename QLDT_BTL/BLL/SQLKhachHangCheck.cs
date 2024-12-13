using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SQLKhachHangCheck
    {
        public string Them(KhachHang kh)
        {
            SQLKhachHang sQLKhachHang = new SQLKhachHang();
            if (kh == null)
            {
                return "Thong Tin trong";
            }

            return sQLKhachHang.Them(kh);
        }
        public string Sua(KhachHang kh)
        {
            SQLKhachHang sQLKhachHang = new SQLKhachHang();
            if (kh == null)
            {
                return "Thong Tin trong";
            }
            return sQLKhachHang.Sua(kh);
        }

        public string Xoa(KhachHang kh)
        {
            SQLKhachHang sQLKhachHang = new SQLKhachHang();
            if (kh == null)
            {
                return "Thong Tin trong";
            }
            return sQLKhachHang.Xoa(kh);
        }

        public DataTable Tim(KhachHang kh)
        {
            SQLKhachHang sQLKhachHang = new SQLKhachHang();
            return sQLKhachHang.TimKiem(kh);
        }

        public DataTable Tim()
        {
            SQLKhachHang sQLKhachHang = new SQLKhachHang();
            return sQLKhachHang.TimKiem();
        }
    }
}
