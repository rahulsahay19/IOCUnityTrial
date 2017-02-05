using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConsumingWCFUnity.Controllers
{
    public class MovieController : Controller
    {
        //
        // GET: /Movie/
        public ActionResult Index()
        {
            var proxy = new ServiceReference1.Service1Client();
            var model = proxy.GetAll();
            return View(model);
        }
	}
}