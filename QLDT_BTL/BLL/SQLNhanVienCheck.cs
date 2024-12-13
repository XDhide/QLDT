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
    public class SQLNhanVienCheck
    {
        public string Them(NhanVien tk)
        {
            SQLNhanVien sQLNhanVien = new SQLNhanVien();
            if (tk == null)
            {
                return "Thong Tin trong";
            }

            return sQLNhanVien.Them(tk);
        }
        public string Sua(NhanVien tk)
        {
            SQLNhanVien sQLNhanVien = new SQLNhanVien();
            if (tk == null)
            {
                return "Thong Tin trong";
            }
            return sQLNhanVien.Sua(tk);
        }

        public string Xoa(NhanVien tk)
        {
            SQLNhanVien sQLNhanVien = new SQLNhanVien();
            if (tk == null)
            {
                return "Thong Tin Trong";
            }
            return sQLNhanVien.Xoa(tk);
        }

        public DataTable Tim(NhanVien tk)
        {
            SQLNhanVien sQLNhanVien = new SQLNhanVien();

            return sQLNhanVien.TimKiem(tk);
        }

        public DataTable Tim()
        {
            SQLNhanVien sQLNhanVien = new SQLNhanVien();

            return sQLNhanVien.TimKiem();
        }
    }
}
