using DagGenerator.App_Code;
using DagGenerator.Models;
using DagGeneratorLibrary;
using System.Web.Mvc;

namespace DagGenerator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {          
            return View();
        }

        public ActionResult GetDag(Settings settings)
        {
            DagSetup setup = new DagSetup
            {
                Settings = settings
            };
            return Json(setup.CreateDag());
        }

        public ActionResult GetDefaultDag()
        {
            DagSetup setup = new DagSetup
            {
                Settings = new Settings()
            };
            return Json(setup.CreateDag());
        }
    }
}