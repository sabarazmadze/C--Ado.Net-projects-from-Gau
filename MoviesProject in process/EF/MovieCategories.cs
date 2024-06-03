using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesProject.EF
{
    [Table("MovieCategories")]
    public class MovieCategories
    {
        public MovieCategories()
        {
            Movies = new HashSet<Movies>();
        }
        [Key]
        public int MovieCategoryID { get; set; }
        [Required]
        [StringLength(100)]
        public string MovieCategoryName { get; set; }
        public virtual ICollection<Movies> Movies { get; set; }
    }
}
