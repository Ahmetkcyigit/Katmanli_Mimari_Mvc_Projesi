using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class IstatistikController : Controller
    {
        // GET: Istatistik
        Context c = new Context();
        public ActionResult Index()
        {
            var a = c.Admins.Count().ToString();
            ViewBag.a1 = a;

            return View();
        }
    }
}