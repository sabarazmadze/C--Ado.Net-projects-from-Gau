using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesProject.EF
{
    [Table("Admins")]
    public class Admins
    {
        [Key]
        public int AdminID { get; set; }
        [Required]
        [StringLength(50)]
        public string AdminUsername { get; set; }
        [Required]
        [StringLength(50)]
        public string AdminPassword { get; set; }

    }
}
