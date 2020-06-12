using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TalanaWebApi.Models.dto;
using TalanaWebApi.Models.Orm;

namespace TalanaWebApi.Controllers
{
    public class KullaniciBilgiController : ApiController
    {
        TalanaEntities db = new TalanaEntities();
        [HttpGet]
        public IHttpActionResult httpActionResult(string id)
        {
            try
            {
                int kID = Convert.ToInt32(id);
                var bilgi = db.Kullanicilar.Where(s => s.Kullanici_ID == kID).FirstOrDefault();
                KullaniciListe kullaniciListe = new KullaniciListe();
                kullaniciListe.Kullanici_ID = bilgi.Kullanici_ID.ToString();
                kullaniciListe.Kullanici_Ad = bilgi.Kullanici_Ad;
                kullaniciListe.Kullanici_Soyad = bilgi.Kullanici_Soyad;
                kullaniciListe.Kullanici_Resim = bilgi.Kullanici_Resim;

                List<Models.dto.KullaniciLog> liste = new List<Models.dto.KullaniciLog>();
                var log = db.KullaniciLog.Where(s => s.Kullanici_ID == kID).ToList();
                foreach (var item in log)
                {
                    Models.dto.KullaniciLog kullaniciLog = new Models.dto.KullaniciLog();
                    kullaniciLog.Girilen_Sifre = item.Girilen_Sifre;
                    kullaniciLog.Kullanici_Sifre = item.Kullanici_Sifre;
                    kullaniciLog.Platform = item.Kullanici_Platform;
                    kullaniciLog.Ip = item.Kullanici_IP;
                    kullaniciLog.Tarih = item.KullaniciLog_Tarih.ToString();
                    liste.Add(kullaniciLog);
                }

                KullaniciBilgiListe kullaniciBilgiListe = new KullaniciBilgiListe();
                kullaniciBilgiListe.liste = liste;
                kullaniciBilgiListe.kullaniciListe = kullaniciListe;
                return Ok(kullaniciBilgiListe);
            }
            catch (Exception ex)
            {
                return Ok();
            }
        }
    }
}
