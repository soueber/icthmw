using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    public class Login
    {
        private DAL.Login Dallogin = new DAL.Login();
        public string UserLogin(Model.Login login)
        {
            return Dallogin.UserLogin(login);
        }
        public string CheckRoot(Model.Login login)
        {
            return Dallogin.CheckRoot(login);
        }
        public string SetLoginSession(Model.Login login)
        {
            return Dallogin.SetLoginSession(login);
        }
        public int UpdateUserRoot(Model.Login login)
        {
            return Dallogin.UpdateUserRoot(login);
        }
        public string GetUserName(Model.Login login)
        {
            return Dallogin.GetUserName(login);
        }
    }
}