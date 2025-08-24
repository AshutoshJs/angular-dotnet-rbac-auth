namespace JwtRoledBasedAuth.Models
{
    public class Employee
    {
        public int? BusinessEntityID { get; set; }
        public string? NationalIDNumber { get; set; }
        public string? LoginID { get; set; }

        // hierarchyid can be tricky — map as string if unsure
       // public string? OrganizationNode { get; set; }

        public short? OrganizationLevel { get; set; }
        public string? JobTitle { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? MaritalStatus { get; set; }
        public string? Gender { get; set; }
        public DateTime? HireDate { get; set; }
        public bool? SalariedFlag { get; set; }
        public short? VacationHours { get; set; }
        public short? SickLeaveHours { get; set; }
        public bool? CurrentFlag { get; set; }
        public Guid? RowGuid { get; set; }
        public DateTime? ModifiedDate { get; set; }
        //public int? BusinessEntityID { get; set; }
        //public string? NationalIDNumber { get; set; }
        //public string? LoginID { get; set; }
        //public string? OrganizationNode { get; set; }
        //public short? OrganizationLevel { get; set; }
        //public string? JobTitle { get; set; }
        //public DateTime? BirthDate { get; set; }
        //public string? MaritalStatus { get; set; }
        //public string? Gender { get; set; }
        //public DateTime? HireDate { get; set; }
        //public bool? SalariedFlag { get; set; }
        //public short? VacationHours { get; set; }
        //public short? SickLeaveHours { get; set; }
        //public bool? CurrentFlag { get; set; }
        //public Guid? RowGuid { get; set; }
        //public DateTime? ModifiedDate { get; set; }

        public Employee()
        {
            
        }
        // Custom constructor initializing all properties to null
        public Employee(string? temp=null)
        {
            this.BusinessEntityID = null;
            this.NationalIDNumber = null;
            this.LoginID = null;
           // this.OrganizationNode = null;
            this.OrganizationLevel = null;
            this.JobTitle = null;
            this.BirthDate = null;
            this.MaritalStatus = null;
            this.Gender = null;
            this.HireDate = null;
            this.SalariedFlag = null;
            this.VacationHours = null;
            this.SickLeaveHours = null;
            this.CurrentFlag = null;
            this.RowGuid = null;
            this.ModifiedDate = null;
        }
    }
}
