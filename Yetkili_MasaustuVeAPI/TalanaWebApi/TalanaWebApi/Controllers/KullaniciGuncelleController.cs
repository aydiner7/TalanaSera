using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TalanaWebApi.Models.Orm;

namespace TalanaWebApi.Controllers
{
    public class KullaniciGuncelleController : ApiController
    {
        TalanaEntities db = new TalanaEntities();
        [HttpGet]
        public IHttpActionResult KullaniciOlustur(String Ad, String Soyad, String Sifre, String Kod)
        {

            try
            {
                Kullanicilar kullanicilar = db.Kullanicilar.Where(s => s.Kullanici_Kod == Kod).FirstOrDefault();
                kullanicilar.Kullanici_Ad = Ad;
                kullanicilar.Kullanici_Resim = Kod + ".jpg";
                kullanicilar.Kullanici_Sifre = Sifre;
                kullanicilar.Kullanici_Soyad = Soyad;
                db.SaveChanges();

                return Ok(true);
            }
            catch (Exception ex)
            {
                return Ok(false);
            }

        }
    }
}