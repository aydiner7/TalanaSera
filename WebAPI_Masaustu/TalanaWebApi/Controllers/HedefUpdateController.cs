using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TalanaWebApi.Models.Orm;

namespace TalanaWebApi.Controllers
{
    
    
    public class HedefUpdateController : ApiController
    {
        TalanaEntities db = new TalanaEntities();
        [HttpGet]
        public IHttpActionResult httpActionResult(String tur, String deger, String SeraID)
        {
            try
            {
                int sID = Convert.ToInt32(SeraID);
                SeraUrun bilgi = db.SeraUrun.Where(s => s.Sera_ID == sID).FirstOrDefault();
                if (tur == "Sicaklik")
                {
                    bilgi.HedefSicaklik = deger;
                }
                if (tur == "Hava")
                {
                    bilgi.HedefHava= deger;
                }
                if (tur == "Nem")
                {
                    bilgi.HedefNem = deger;
                }
                if (tur == "Isik")
                {
                    bilgi.HedefIsik = deger;
                }

                db.SaveChanges();
                return Ok(1);
            }
            catch (Exception ex)
            {
                return Ok();
            }
        }
    }
}
