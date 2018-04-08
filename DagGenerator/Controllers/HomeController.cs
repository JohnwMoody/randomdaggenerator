using DagGenerator.App_Code;
using DagGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;

namespace DagGenerator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {          
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

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