using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FYP.App_Code.DomainClasses
{
    class clsPasswordManagerDB
    {

        public int ID { get; set; }
        public string URL { get; set; }
        public string Name { get; set; }
        public string Usernames { get; set; }
        public string Passwords { get; set; }
        public string Note { get; set; }
        public string FKUsername { get; set; }
    }
}
