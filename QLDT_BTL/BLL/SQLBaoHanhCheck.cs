using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SQLBaoHanhCheck
    {
        public string Them(BaoHanh bh)
        {
            SQLBaoHanh sQLBaoHanh = new SQLBaoHanh();
            if (bh == null)
            {
                return "Thong Tin trong";
            }

            return sQLBaoHanh.Them(bh);
        }
        public string Sua(BaoHanh bh)
        {
            SQLBaoHanh sQLBaoHanh = new SQLBaoHanh();
            if (bh == null)
            {
                return "Thong Tin trong";
            }
            return sQLBaoHanh.Sua(bh);
        }

        public string Xoa(BaoHanh bh)
        {
            SQLBaoHanh sQLBaoHanh = new SQLBaoHanh();
            if (bh == null)
            {
                return "Thong Tin trong";
            }
            return sQLBaoHanh.Xoa(bh);
        }

        public DataTable Tim(BaoHanh bh)
        {
            SQLBaoHanh sQLBaoHanh = new SQLBaoHanh();
            return sQLBaoHanh.TimKiem(bh);
        }

        public DataTable Tim()
        {
            SQLBaoHanh sQLBaoHanh = new SQLBaoHanh();
            return sQLBaoHanh.TimKiem();
        }
    }
}
