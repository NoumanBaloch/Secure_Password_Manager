using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FYP.App_Code.DomainClasses
{
    class clsUserDB
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Salt { get; set; }
        public int ClickPointOnXAxis { get; set; }
        public int ClickPointOnYAxis { get; set; }
    }
}
