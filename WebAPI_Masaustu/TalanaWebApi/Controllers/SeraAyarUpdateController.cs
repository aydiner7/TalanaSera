using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TalanaWebApi.Models.Orm;

namespace TalanaWebApi.Controllers
{
    public class SeraAyarUpdateController : ApiController
    {
        TalanaEntities db = new TalanaEntities();
        [HttpGet]
        public IHttpActionResult httpAction(string Tur, string SeraID, string maxDeger,string minDeger)
        {
            try
            {
                
                int sID = Convert.ToInt32(SeraID);
                var UID = db.SeraUrun.Where(s => s.Sera_ID == sID).FirstOrDefault();
                var ozellik = db.UrunOzellik.Where(s => s.Urun_ID == UID.Urun_ID).FirstOrDefault();
                if (Tur == "Sicaklik")
                {
                    UID.MaxSicaklik = maxDeger;
                    UID.MinSicaklik = minDeger;
                }
                else if (Tur == "Hava")
                {
                    UID.MaxHava = maxDeger;
                    UID.MinHava = minDeger;
                }
                else if (Tur == "Nem")
                {
                    UID.MaxNem = maxDeger;
                    UID.MinNem = minDeger;
                }
                else if (Tur == "Isik")
                {
                    UID.MaxIsik = maxDeger;
                    UID.MinIsik = minDeger;
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
