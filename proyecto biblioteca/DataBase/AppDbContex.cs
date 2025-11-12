using Microsoft.EntityFrameworkCore;
using proyecto_biblioteca.DataBase.Modelos;

namespace proyecto_biblioteca.DataBase
{
    public class AppDbContex: DbContext
    {
        public AppDbContex(DbContextOptions<AppDbContex> Options):base(Options)
        { }
        public DbSet<Book> Book { get; set; }
    }
}
