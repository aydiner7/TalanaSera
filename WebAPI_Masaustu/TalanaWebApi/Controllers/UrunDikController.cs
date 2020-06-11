using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TalanaWebApi.Models.Orm;

namespace TalanaWebApi.Controllers
{
    public class UrunDikController : ApiController
    {
        TalanaEntities db = new TalanaEntities();
        [HttpGet]
        public IHttpActionResult httpAction(string SeraID, string UrunID)
        {
            try
            {
                int ID = Convert.ToInt32(UrunID);
                var urunOzellik = db.UrunOzellik.Where(s => s.Urun_ID == ID).FirstOrDefault();
                SeraUrun seraUrun = new SeraUrun();
                seraUrun.Sera_ID = Convert.ToInt32(SeraID);
                seraUrun.Urun_ID = Convert.ToInt32(UrunID);
                seraUrun.MaxHava = urunOzellik.UrunOzellik_MaxHavaKalite;
                seraUrun.MinHava = urunOzellik.UrunOzellik_MinHavaKalite;
                seraUrun.MaxIsik = urunOzellik.UrunOzellik_MaxIsikSiddet;
                seraUrun.MinIsik = urunOzellik.UrunOzellik__MinIsikSiddet;
                seraUrun.MaxNem = urunOzellik.UrunOzellik_MaxNem;
                seraUrun.MinNem = urunOzellik.UrunOzellik_MinNem;
                seraUrun.MaxSicaklik = urunOzellik.UrunOzellik_MaxSicaklik;
                seraUrun.MinSicaklik = urunOzellik.UrunOzellik_MinSicaklik;
                seraUrun.MaxToprakNem = urunOzellik.UrunOzellik_MaxToprakNem;
                seraUrun.MinToprakNem = urunOzellik.UrunOzellik_MinToprakNem;
                seraUrun.Sera_EkimTarih = DateTime.Now;
                seraUrun.Sera_HasatTarih = DateTime.Now.AddDays(Convert.ToInt32(urunOzellik.UrunOzellik_HasatSure));
                db.SeraUrun.Add(seraUrun);
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
