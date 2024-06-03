using MoviesProject.EF;
using MoviesProject.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MoviesProject
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
           
            try
            {
                using (MoviesDBContext db = new MoviesDBContext())
                {
                    //Genre g1 = new Genre();
                    //g1.Name = "რომანტიული";
                    //Genre g2 = new Genre();
                    //g2.Name = "სათავგადასავლო";
                    //Genre g3 = new Genre();
                    //g3.Name = "ბიოგრაფიული";
                    //db.Genres.AddRange(new List<Genre> { g1, g2, g3 });
                    //db.SaveChanges();

                    //Nationalities n1 = new Nationalities();
                    //n1.NationalityName = "Georgian";
                    //db.Nationalities.Add(n1);

                    //Movie movie = new Movie();
                    //movie.Name = "სიყვარული ყველას უნდა";
                    //movie.Director = "ელდარ შენგელაია";
                    //movie.Description = "სასიყვარული ისტორია ახალგაზრდა წყვილზე,რომელიც ვითარდება ძველი თბილის მახლობლად.";
                    //movie.ReleaseYear = 1980;
                    //movie.GenreId = 1;
                    //db.Movies.Add(movie);
                    //db.SaveChanges();

                    //Movie movie = new Movie();
                    //movie.Name = "რაჭა ჩემი სიყვარული";
                    //movie.Director = "თემურ ფალავანდიშვილი";
                    //movie.Description = "სასიყვარული ისტორია ახალგაზრდა წყვილზე,რომელიც ვითარდება რაჭაში.";
                    //movie.ReleaseYear = 1977;
                    //movie.GenreId = 1;
                    //db.Movies.Add(movie);
                    //db.SaveChanges();

                    //Movie movie_updated = db.Movies.Single(i => i.Id == 1);
                    //movie_updated.Description = $"{movie_updated.Description}; შესანიშნავი სახალისო ფილმია!";
                    //db.SaveChanges();


                    Console.WriteLine("DONE");
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Home());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }
        }
    }
}
