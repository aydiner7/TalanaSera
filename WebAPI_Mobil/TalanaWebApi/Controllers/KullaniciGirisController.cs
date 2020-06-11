using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TalanaWebApi.Models;
using TalanaWebApi.Models.Orm;
using Newtonsoft.Json;
using TalanaWebApi.Models.dto;

namespace TalanaWebApi.Controllers
{
    public class KullaniciGirisController : ApiController
    {
        TalanaEntities db = new TalanaEntities();
        [HttpGet]
        public IHttpActionResult Giris(string kod, string sifre)
        {
            try
            {
                Kullanici kullanici = new Kullanici();
                Kullanicilar kullanicilar = db.Kullanicilar.Where(s => s.Kullanici_Kod == kod && s.Kullanici_Sifre == sifre).FirstOrDefault();
                kullanici.Kod = kullanicilar.Kullanici_Kod;
                kullanici.ID = kullanicilar.Kullanici_ID;
                kullanici.Soyad = kullanicilar.Kullanici_Soyad;
                kullanici.Ad = kullanicilar.Kullanici_Ad;
                kullanici.Resim = kullanicilar.Kullanici_Resim;
                return Ok(kullanici);
            }
            catch (Exception ex)
            {
                return Ok();
            }
        }
    }
}
