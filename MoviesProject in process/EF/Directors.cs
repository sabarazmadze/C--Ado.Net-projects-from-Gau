using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesProject.EF
{
    [Table("Directors")]
    public class Directors
    {
        public Directors()
        {
            Movies = new HashSet<Movies>();
        }
        [Key]
        public int DirectorID { get; set; }
        [Required]
        [StringLength(50)]
        public string DirectorFirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string DirectorLastName { get; set; }
        public int NationalityID { get; set; }
        public virtual Nationalities Nationalities { get; set; }
        public virtual ICollection<Movies> Movies { get; set; }
    }
}
