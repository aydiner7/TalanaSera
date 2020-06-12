using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TalanaWebApi.Models;
using TalanaWebApi.Models.Orm;

namespace TalanaWebApi.Controllers
{
    public class KullaniciEkleController : ApiController
    {
        TalanaEntities db = new TalanaEntities();
        [HttpGet]
        public IHttpActionResult KullaniciOlustur(String Ad, String Soyad, String Sifre, String Kod)
        {

            try
            {
                Kullanicilar kullanicilar = new Kullanicilar();
                kullanicilar.Kullanici_Ad = Ad;
                kullanicilar.Kullanici_Kod = Kod;
                kullanicilar.Kullanici_Resim = Kod + ".jpg";
                kullanicilar.Kullanici_Sifre = Sifre;
                kullanicilar.Kullanici_Soyad = Soyad;
                db.Kullanicilar.Add(kullanicilar);
                db.SaveChanges();

                return Ok(true);
            }
            catch (Exception ex)
            {
                return Ok(false);
            }

        }

      
        [HttpPost]
        public IHttpActionResult KullaniciOlustur2(String Ad, String Soyad, String Sifre, String Kod)
        {

            try
            {
                Kullanicilar kullanicilar = new Kullanicilar();
                kullanicilar.Kullanici_Ad = Ad;
                kullanicilar.Kullanici_Kod = Kod;
                kullanicilar.Kullanici_Resim = Kod + ".jpg";
                kullanicilar.Kullanici_Sifre = Sifre;
                kullanicilar.Kullanici_Soyad = Soyad;
                db.Kullanicilar.Add(kullanicilar);
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