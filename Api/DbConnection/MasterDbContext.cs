using JwtRoledBasedAuth.Models;
using Microsoft.EntityFrameworkCore;

namespace JwtRoledBasedAuth.DbConnection
{
    public class MasterDbContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        public DbSet<PersonEmailAddress> PersonEmailAddress { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ASHUTOSH-PC\MSSQLSERVER01;Database=JWT_Adventutrworks;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Map Employee to HumanResources.Employee
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee", "HumanResources");
                entity.HasKey(e => e.BusinessEntityID);
                entity.Property(e => e.BusinessEntityID).HasColumnName("BusinessEntityID");
                entity.Property(e => e.NationalIDNumber).HasColumnName("NationalIDNumber");
                entity.Property(e => e.LoginID).HasColumnName("LoginID");
               // entity.Property(e => e.OrganizationNode).HasColumnName("OrganizationNode"); was creating datatype issue
                entity.Property(e => e.OrganizationLevel).HasColumnName("OrganizationLevel");
                entity.Property(e => e.JobTitle).HasColumnName("JobTitle");
                entity.Property(e => e.BirthDate).HasColumnName("BirthDate");
                entity.Property(e => e.MaritalStatus).HasColumnName("MaritalStatus");
                entity.Property(e => e.Gender).HasColumnName("Gender");
                entity.Property(e => e.HireDate).HasColumnName("HireDate");
                entity.Property(e => e.SalariedFlag).HasColumnName("SalariedFlag");
                entity.Property(e => e.VacationHours).HasColumnName("VacationHours");
                entity.Property(e => e.SickLeaveHours).HasColumnName("SickLeaveHours");
                entity.Property(e => e.CurrentFlag).HasColumnName("CurrentFlag");
                entity.Property(e => e.RowGuid).HasColumnName("rowguid");
                entity.Property(e => e.ModifiedDate).HasColumnName("ModifiedDate");
            });

            modelBuilder.Entity<PersonEmailAddress>(entity =>
            {
                entity.ToTable("EmailAddress", "Person");
                entity.HasKey(e => e.BusinessEntityID);
                entity.Property(e => e.BusinessEntityID).HasColumnName("BusinessEntityID");
                entity.Property(e => e.EmailAddressID).HasColumnName("EmailAddressID");
                entity.Property(e => e.EmailAddress).HasColumnName("EmailAddress");
                entity.Property(e => e.ModifiedDate).HasColumnName("ModifiedDate");
            });
        }
    }
}
