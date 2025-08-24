

using Microsoft.EntityFrameworkCore;

namespace JwtRoledBasedAuth.DbConnection
{
    public class PersonDbContext : DbContext
    {
      
        public PersonDbContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //use this to configure the contex
        
        }


    }
}
