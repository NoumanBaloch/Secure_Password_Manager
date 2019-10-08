using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FYP.App_Code.DomainClasses
{
    class clsAddressDB
    {
        public int AddressID { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDay { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string PhoneNo { get; set; }
        public string Note { get; set; }
        public string FKUsername { get; set; }
    }
}
