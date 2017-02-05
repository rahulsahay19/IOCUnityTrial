using System.Collections.Generic;
using System.Linq;
using IOCUnityTrial.Models;

namespace IOCUnityTrial.Repository
{
    public class RepoImpl : IRepository
    {
        public IEnumerable<Movie> GetAll()
        {
            return new List<Movie>
            {
                new Movie()
                {
                    Id = 1,
                    DirectorName = "James Cameron",
                    MovieName = "Avatar",
                    ReleaseYear = "2009"
                },
                new Movie()
                {
                    Id = 2,
                    DirectorName = "James Cameron",
                    MovieName = "Titanic",
                    ReleaseYear = "1997"
                },
                new Movie()
                {
                    Id = 3,
                    DirectorName = "Lee Tamahori",
                    MovieName = "Die Another Day",
                    ReleaseYear = "2002"
                }

            };
        }

        public Movie GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Add(Movie entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Movie entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Movie entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}