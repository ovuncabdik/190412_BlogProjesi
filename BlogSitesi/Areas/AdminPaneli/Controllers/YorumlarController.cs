using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSitesi.Areas.AdminPaneli.Controllers
{
    public class YorumlarController : Controller
    {
        // GET: AdminPaneli/Yorumlar
        public ActionResult Index()
        {
            return View();
        }
    }
}