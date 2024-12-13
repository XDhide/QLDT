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
    public class SQLDonHangBanCheck
    {
        public string Them(DonHangBan dhb)
        {
            SQLDonHangBan sQLDonHangBan = new SQLDonHangBan();
            if (dhb == null)
            {
                return "Thong Tin trong";
            }

            return sQLDonHangBan.Them(dhb);
        }
        public string Sua(DonHangBan dhb)
        {
            SQLDonHangBan sQLDonHangBan = new SQLDonHangBan();
            if (dhb == null)
            {
                return "Thong Tin trong";
            }
            return sQLDonHangBan.Sua(dhb);
        }

        public string Xoa(DonHangBan dhb)
        {
            SQLDonHangBan sQLDonHangBan = new SQLDonHangBan();
            if (dhb == null)
            {
                return "Thong Tin trong";
            }
            return sQLDonHangBan.Xoa(dhb);
        }

        public DataTable Tim(DonHangBan dhb)
        {
            SQLDonHangBan sQLDonHangBan = new SQLDonHangBan();
            return sQLDonHangBan.TimKiem(dhb);
        }

        public DataTable Tim()
        {
            SQLDonHangBan sQLDonHangBan = new SQLDonHangBan();
            return sQLDonHangBan.TimKiem();
        }
    }
}
