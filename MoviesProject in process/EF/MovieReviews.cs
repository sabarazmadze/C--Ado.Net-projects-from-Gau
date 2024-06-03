using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace MoviesProject.EF
{
    [Table("MovieReviews")]
    public class MovieReviews
    {

        [Key]
        public int MovieReviewID { get; set; }
        [Required]
        public int MovieID {  get; set; }
        [Required]
        public decimal Score {  get; set; }
        [Column(TypeName = "date")]
        public DateTime ReviewDate { get; set; } = DateTime.Now;
        [StringLength(200)]
        public string Comment { get; set; } = null;
        public virtual Movies Movies { get; set; }
    }
}
