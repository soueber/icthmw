using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    public class User
    {
        private DAL.User Daluser = new DAL.User();
        public string GetUserInfo(Model.User user, string fieid)
        {
            return Daluser.GetUserInfo(user, fieid);
        }
    }
}