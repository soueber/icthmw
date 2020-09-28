using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    public class Login
    {
        public int Id{get;set;}
        public string Email { get; set; }
        public string Name { get; set; }
        public string Pwd { get; set; }
        public int Root { get; set; }
    }
}