using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSitesi.Controllers
{
    public class UyelikPaneliController : Controller
    {
        Models.Bloghi304DBEntities db = new Models.Bloghi304DBEntities();
        // GET: UyelikPaneli
        public ActionResult UyelikPaneliIndex()
        {
            /*https://bootsnipp.com/snippets/dldxB */
            return View();
        }

        [HttpPost]
        public ActionResult UyelikPaneliIndex(string uname,string psw)
        {
            var Giris = db.Uyeler.Where(k => k.KullaniciAdi == uname && k.Kullanicisifresi == psw).FirstOrDefault();
            Session["UyeAdi"] = Giris.Adi;
            //Session["YetkiAdi"] = db.Yetkiler.Where(l => l.YetkilerID == Giris.YetkiID).FirstOrDefault().YetkiAdi;

            if (Giris!=null)
            {
                if (Session["YetkiAdi"].ToString() == "Admin" || Session["YetkiAdi"].ToString() == "Yazar")
                {
                    //return RedirectToAction("AnaSayfaIndex", "AdminPaneliAnasayfa", "AdeminPaneli");
                    //ViewBag.mesaj = Session["YetkiAdi"];
                    return RedirectToAction("Index", "Default");
                }
                else
                {

                } 
            }
            else
            {
                ViewBag.mesaj = "Hatalı Giriş";


                return View();
            }

            return View();
        }
    }
}