using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSitesi.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult DefaultIndex()
        {
            return View();
        }
    }
}