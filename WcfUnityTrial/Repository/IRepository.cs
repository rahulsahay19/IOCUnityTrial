using System.Collections.Generic;
using System.ServiceModel;
using WcfUnityTrial.Model;

namespace WcfUnityTrial.Repository
{
    [ServiceContract]
    public interface IRepository
    {
        //To query using LINQ
        [OperationContract]
        IEnumerable<Movie> GetAll();

        //Returning Movie or Review by id
        [OperationContract]
        Movie GetById(int id);

        //Adding Movie or Review
        [OperationContract]
        void Add(Movie entity);

        //Updating Movie or Review
        [OperationContract]
        void Update(Movie entity);

        //Deleting Moovie or Review
        [OperationContract]
        void Delete(Movie entity);

        //Deleting Movie or Review by id
        [OperationContract]
        void Delete(int id);

    }
}
