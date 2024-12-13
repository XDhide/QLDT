using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class SQLTaiKhoanCheck
    {
        public string Them(TaiKhoan tk)
        {
            SqlTaiKhoan sqlTaiKhoan = new SqlTaiKhoan();
            if (tk == null )
            {
                return "Thong Tin trong";
            }

            return sqlTaiKhoan.Them(tk);
        }
        public string Sua(TaiKhoan tk)
        {
            SqlTaiKhoan sqlTaiKhoan = new SqlTaiKhoan();
            if (tk == null)
            {
                return "Thong Tin trong";
            }
            return sqlTaiKhoan.Sua(tk);
        }

        public string Xoa(TaiKhoan tk)
        {
            SqlTaiKhoan sqlTaiKhoan = new SqlTaiKhoan();
            if (tk == null)
            {
                return "Thong Tin Trong";
            }
            return sqlTaiKhoan.Xoa(tk);
        }

        public DataTable Tim(TaiKhoan tk)
        {
            SqlTaiKhoan sqlTaiKhoan = new SqlTaiKhoan();

            return sqlTaiKhoan.TimKiem(tk);
        }

        public DataTable Tim()
        {
            SqlTaiKhoan sqlTaiKhoan = new SqlTaiKhoan();

            return sqlTaiKhoan.TimKiem();
        }
    }
}
