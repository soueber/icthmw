using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    public class IpStat
    {
        public int Id
        {
            get;
        }
        public string Ip
        {
            get; set;
        }
        public string Ipsrc
        {
            get;set;
        }
        public DateTime Datetime
        {
            get;
        }
        public string City { get; set; }
    }
}