using BlogSitesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSitesi.Controllers
{
    public class YorumlarController : Controller
    {
        Models.Bloghi304DBEntities db = new Models.Bloghi304DBEntities();
        // GET: Yorumlar

        public ActionResult YorumIndex()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult YorumEkleIndex(string YorumBaslik,string Yorumicerik,DateTime YorumTarihi,int UyeID,int BegenmeSayisi,int MakaleID,bool Aktifmi,DateTime GuncellemeTarihi)
        //{

        //    YorumEkle(YorumBaslik,Yorumicerik,YorumTarihi,UyeID,BegenmeSayisi,MakaleID,Aktifmi,GuncellemeTarihi);
        //    return View();
        //}

        #region Yorum Test
        public int YorumEkle(string yorumBaslik, string yorumicerik, DateTime yorumtarihi, int uye_id, int begenmeSayisi, int makale_id, bool aktifmi, DateTime guncellemeTarihi)
        {
            Yorumlar ekle = new Yorumlar();
            ekle.YorumBaslik = yorumBaslik;
            ekle.Yorumicerik = yorumicerik;
            ekle.YorumTarihi = yorumtarihi;
            ekle.UyeID = uye_id;
            ekle.BegenmeSayisi = begenmeSayisi;
            ekle.MakaleID = makale_id;
            ekle.Aktifmi = aktifmi;
            ekle.GuncellemeTarihi = guncellemeTarihi;
            int sonuc = db.SaveChanges();
            if (sonuc > 0)
            {
                return 1;
            }
            return 0;
        }
        #endregion

        [HttpPost]
        public ActionResult YorumEklePartialIndex(string YorumBaslik, string Yorumicerik, DateTime YorumTarihi, int UyeID, int BegenmeSayisi, int MakaleID, bool Aktifmi, DateTime GuncellemeTarihi)
        {

            YorumEkle(YorumBaslik, Yorumicerik, YorumTarihi, UyeID, BegenmeSayisi, MakaleID, Aktifmi, GuncellemeTarihi);
            return View();
        }

        
    }
}