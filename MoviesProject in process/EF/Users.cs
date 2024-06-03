using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesProject.EF
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        [StringLength(50)]
        public string UserUsername { get; set; }
        [Required]
        [StringLength(50)]
        public string UserPassword { get; set; }

    }
}
