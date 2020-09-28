using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    public class IpStat
    {
        private DAL.IpStat Dalipstat = new DAL.IpStat();
        public int InsertIpStat(Model.IpStat ipStat)
        {
            return Dalipstat.InsertIpStat(ipStat);
        }
    }
}