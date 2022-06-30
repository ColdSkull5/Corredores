using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Corredores.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Proveedores()
        {
            ViewBag.Message = "Proveedores.";

            return View();
        }

        //public ActionResult Cliente()
        //{
        //    ViewBag.Message = "Cliente.";

        //    return View();
        //}

        //public ActionResult Productos()
        //{
        //    ViewBag.Message = "Productos.";

        //    return View();
        //}

        public ActionResult Contabilidad()
        {
            ViewBag.Message = "Contabilidad.";

            return View();
        }
    }
}