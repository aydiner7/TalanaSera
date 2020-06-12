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
    public class KullanicilarController : ApiController
    {
        TalanaEntities db = new TalanaEntities();
        public IHttpActionResult GetAll()
        {
            try
            {
                var kullanici = db.Kullanicilar.ToList();
                List<KullaniciListe> liste = new List<KullaniciListe>();
                foreach (var item in kullanici)
                {
                    KullaniciListe kullanici1 = new KullaniciListe();
                    kullanici1.Kullanici_ID = item.Kullanici_ID.ToString();
                    kullanici1.Kullanici_Ad = item.Kullanici_Ad.ToString();
                    kullanici1.Kullanici_Soyad = item.Kullanici_Soyad.ToString();
                    kullanici1.Kullanici_Resim = item.Kullanici_Resim.ToString();
                    liste.Add(kullanici1);
                }
                return Ok(liste);
            }
            catch (Exception ex)
            {
                return Ok();
            }
        }
    }
}

 