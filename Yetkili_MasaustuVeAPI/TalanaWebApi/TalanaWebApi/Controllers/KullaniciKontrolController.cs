using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TalanaWebApi.Models.Orm;

namespace TalanaWebApi.Controllers
{
    
    public class KullaniciKontrolController : ApiController
    {
        TalanaEntities db = new TalanaEntities();
        
        [HttpGet]
        public string KullaniciKontrol(String kod)
        {
            try
            {
                
                Kullanicilar kullanicilar = db.Kullanicilar.Where(s => s.Kullanici_Kod == kod).FirstOrDefault();
                return kullanicilar.Kullanici_Resim.ToString();
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
                return null;
            }
        }
    }
}
