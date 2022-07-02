using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class MemberObject
    {
        private string MemberID { get; set; }
        private string MemberName { get; set; }
        private string MemberEmail { get; set; }
        private string Password { get; set; }
        private string City { get; set; }
        private string Country { get; set; }

        public MemberObject()
        {
        }

        public MemberObject(string memberID, string memberName, string memberEmail, string password, string city, string country)
        {
            MemberID = memberID;
            MemberName = memberName;
            MemberEmail = memberEmail;
            Password = password;
            City = city;
            Country = country;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
