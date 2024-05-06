using Microsoft.EntityFrameworkCore;
using SimpleLibraryAPI.Entidades;

namespace SimpleLibraryAPI
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Libro> Libro { get; set; }
    }
}
