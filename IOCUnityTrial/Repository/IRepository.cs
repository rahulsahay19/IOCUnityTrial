using System.Collections.Generic;
using System.Linq;
using IOCUnityTrial.Models;

namespace IOCUnityTrial.Repository
{
    public interface IRepository
    {
        //To query using LINQ
        IEnumerable<Movie> GetAll();

        //Returning Movie or Review by id
       Movie GetById(int id);

        //Adding Movie or Review
        void Add(Movie entity);

        //Updating Movie or Review
        void Update(Movie entity);

        //Deleting Moovie or Review
        void Delete(Movie entity);

        //Deleting Movie or Review by id
        void Delete(int id);

    }
}
