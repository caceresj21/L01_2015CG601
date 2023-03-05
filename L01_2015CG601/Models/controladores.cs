using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace L01_2015CG601.Models
{
    public class controladores : DbContext
    {
        public controladores(DbContextOptions<controladores> options) : base(options)
        {

        }
        public DbSet<usuarios> usuarios { get; set; } = null!;
        public DbSet<calificaciones> calificaciones { get; set; } = null!;
        public DbSet<comentarios> comentarios { get; set; } = null!;
    }
}

