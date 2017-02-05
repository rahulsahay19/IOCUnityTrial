using System.Web.Mvc;
using IOCUnityTrial.Repository;

namespace IOCUnityTrial.Controllers
{
    public class MovieController : Controller
    {
        private IRepository _repository;

        public MovieController(IRepository repository)
        {
            _repository = repository;
        }
        //
        // GET: /Movie/
        public ActionResult Index()
        {
            var model = _repository.GetAll();
            return View(model);
        }
	}
}