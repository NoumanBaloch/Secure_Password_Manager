using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FYP.App_Code.DomainClasses
{
    class clsPaymentCardDB
    {
        public int CardID { get; set; }
        public string NameOnCard { get; set; }
        public string Type { get; set; }
        public string Number { get; set; }
        public string SecurityCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Note { get; set; }
        public string FKUsername { get; set; }
    }
}
