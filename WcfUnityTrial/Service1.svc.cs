using System;
using System.Collections.Generic;
using WcfUnityTrial.Repository;

namespace WcfUnityTrial
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private IRepository _repository;

        //Below is there just to complete the signature
        //Refer http://www.devtrends.co.uk/blog/introducing-unity.wcf-providing-easy-ioc-integration-for-your-wcf-services
        //for work around
        public Service1()
        {
            //Since, the below ctor is not hitting; hence in parameterless ctor made below call.
            _repository = new RepoImpl();
        }

        //TODO: This ctor is not hitting beacuse factory is unable to understand that
        public Service1(IRepository repository)
        {
            _repository= new RepoImpl();
            //TODO:- Need a work around to make this possible
           // _repository = repository;
        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }


        public IEnumerable<Model.Movie> GetAll()
        {
          return _repository.GetAll();
        }
    }
}
