using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesProject.EF
{
    [Table("Movies")]
    public class Movies
    {
        public Movies()
        {
            MovieReviews = new HashSet<MovieReviews>();
        }
        [Key]
        public int MovieID { get; set; }
        [Required]
        public int MovieCategoryID { get; set; }
        [Required]
        [StringLength(150)]
        public string Title { get; set; }
        [Required]
        public int DirectorID { get; set; }
        public int? DurationInMinutes { get; set; }
        public int? YearOfRelease { get; set;}
        public virtual Directors Directors { get; set; }
        public virtual MovieCategories MovieCategories { get; set; }
        public virtual ICollection<MovieReviews> MovieReviews { get; set;}

    }
}
