using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyecto_biblioteca.DataBase.Models
{
    [Table("Users", Schema = "dbo")]
    public class User
    {
        [Column("User")]
       public string UserLogin { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool Active { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public string Name { get; set; }
        [Key]
        public int Id { get; set; }
       
    }
}
