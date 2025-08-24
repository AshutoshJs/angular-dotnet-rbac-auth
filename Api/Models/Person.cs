namespace JwtRoledBasedAuth.Models
{
    public class Person
    {
        public int? BusinessEntityID { get; set; }
        public string? PersonType { get; set; }
        public bool? NameStyle { get; set; }
        public string? Title { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Suffix { get; set; }
        public int? EmailPromotion { get; set; }
        public string? AdditionalContactInfo { get; set; }
        public string? Demographics { get; set; }
        public Guid? RowGuid { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public Person() {}
        public Person(string? temp = null)
        {
            this.BusinessEntityID = null;
            this.PersonType = null;
            this.NameStyle = null;
            this.Title = null;
            this.FirstName = null;
            this.MiddleName = null;
            this.LastName = null;
            this.Suffix = null;
            this.EmailPromotion = null;
            this.AdditionalContactInfo = null;
            this.Demographics = null;
            this.RowGuid = null;
            this.ModifiedDate = null;
        }
    }
}
