using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FYP.App_Code.DomainClasses
{
    class clsBankAccountsDB
    {
        public int BankID { get; set; }
        public string BankName { get; set; }
        public string AccountType { get; set; }
        public string RoutingNumber { get; set; }
        public string AccountNumber { get; set; }
        public string SWIFTCode { get; set; }
        public string IBANNumber { get; set; }
        public string Pin { get; set; }
        public string BranchAddress { get; set; }
        public string BranchPhone { get; set; }
        public string Note { get; set; }
        public string FKUsername { get; set; }
    }
}
