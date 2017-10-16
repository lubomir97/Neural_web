using NeuralNetworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NeuralNetworks.Controllers
{
    public class HomeController : Controller
    {
        InputContext icx = new InputContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View(icx.DataInputs);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}