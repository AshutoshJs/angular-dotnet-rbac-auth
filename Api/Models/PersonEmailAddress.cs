using System.Net.Mail;

namespace JwtRoledBasedAuth.Models
{
    public class PersonEmailAddress
    {
        public int BusinessEntityID { get; set; }

        public int EmailAddressID { get; set; }

        public string EmailAddress { get; set; }

        public DateTime ModifiedDate { get; set; }

        public PersonEmailAddress() {}
        public PersonEmailAddress(int BusinessEntityID, int EmailAddressID,string EmailAddress, DateTime ModifiedDate)
        {
            this.BusinessEntityID = BusinessEntityID;
            this.EmailAddressID = EmailAddressID;
            this.EmailAddress = EmailAddress;
            this.ModifiedDate = ModifiedDate;
        }
    }
}
