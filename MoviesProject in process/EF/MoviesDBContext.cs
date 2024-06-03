using System;
using System.Data.Entity;
using System.Linq;

namespace MoviesProject.EF
{
    public class MoviesDBContext : DbContext
    {
        public MoviesDBContext() : base("name=MoviesDBContext")
        {

        }

        public virtual DbSet<Directors> Directors { get; set; }
        public virtual DbSet<MovieCategories> MovieCategories { get; set; }
        public virtual DbSet<MovieReviews> MovieReviews { get; set; }
        public virtual DbSet<Movies> Movies { get; set; }
        public virtual DbSet<Nationalities> Nationalities { get; set; }
        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nationalities>()
                .HasMany(e => e.Directors)
                .WithRequired(e => e.Nationalities)
                .HasForeignKey(e => e.NationalityID);

            modelBuilder.Entity<Directors>()
                .HasMany(e => e.Movies)
                .WithRequired(e => e.Directors)
                .HasForeignKey(e => e.DirectorID);

            modelBuilder.Entity<Movies>()
                .HasMany(e => e.MovieReviews)
                .WithRequired(e => e.Movies)
                .HasForeignKey(e => e.MovieID);

            modelBuilder.Entity<MovieCategories>()
                .HasMany(e => e.Movies)
                .WithRequired(e => e.MovieCategories)
                .HasForeignKey(e => e.MovieCategoryID);

            modelBuilder.Entity<Admins>()
                .HasKey(e => e.AdminID);

            modelBuilder.Entity<Users>()
                .HasKey(e => e.UserID);
        }
    }
}