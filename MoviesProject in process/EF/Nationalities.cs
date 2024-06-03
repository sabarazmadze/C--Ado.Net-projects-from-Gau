using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesProject.EF
{
    [Table("Nationalities")]
    public class Nationalities
    {
        public Nationalities()
        {
            Directors = new HashSet<Directors>();
        }
        [Key]
        public int NationalityID { get; set; }
        [Required]
        [StringLength(100)]
        public string NationalityName { get; set; }
        public virtual ICollection<Directors> Directors { get; set; }
    }
}
