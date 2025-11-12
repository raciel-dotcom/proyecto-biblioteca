using Microsoft.EntityFrameworkCore;
using proyecto_biblioteca.DataBase.Modelos;
using proyecto_biblioteca.DataBase.Models;

namespace proyecto_biblioteca.DataBase
{
    public class AppDbContex: DbContext
    {
        public AppDbContex(DbContextOptions<AppDbContex> Options):base(Options)
        { }
        public DbSet<Book> Book { get; set; }
        public DbSet<User> User { get; set; }
    }
}
