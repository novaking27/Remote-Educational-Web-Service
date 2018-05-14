using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RemoteEducationalServicesWebService.Model
{
  
    public class User
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string dateOfBirth { get; set; }
        public int phoneNumber { get; set; }
        public string streetName { get; set; }
        public int houseNumber { get; set; }
        public int unitNumber { get; set; }
        public string suburb { get; set; }
        public string state { get; set; }
        public int postCode { get; set; }
    }
}