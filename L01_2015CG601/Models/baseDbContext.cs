using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;




namespace L01_2015CG601.Models
{
    public class baseDbContext : DbContext
    {
        public baseDbContext(DbContextOptions<baseDbContext> options) : base (options)
        { 
        
        
        
        }

        public DbSet<baseDb> baseDb { get; set; }  
    }


    
}
