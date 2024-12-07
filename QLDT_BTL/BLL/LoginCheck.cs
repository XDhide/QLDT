using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoginCheck
    {
        public LoginTable Table = new LoginTable();
        public string Login(string username, string password)
        {
            if(username == null || password == null)
            {
                return "Tai Khoan Hoac Mat Khau Trong";
            }
            return Table.DangNhap(username, password);
        }
    }
}
