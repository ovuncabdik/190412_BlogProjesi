using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSitesi.Controllers
{
    public class HakkimizdaController : Controller
    {
        // GET: Hakkimizda
        public ActionResult HakkimizdaIndex()
        {
            return View();
        }
    }
}