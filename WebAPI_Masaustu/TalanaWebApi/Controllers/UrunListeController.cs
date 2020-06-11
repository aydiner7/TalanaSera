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
    public class UrunListeController : ApiController
    {
        TalanaEntities db = new TalanaEntities();
        [HttpGet]
        public IHttpActionResult httpAction()
        {
            try
            {
                List<UrunListesi> uruns = new List<UrunListesi>();
                var urunler = db.Urunler.Where(s => s.Urun_Aktif == true).ToList();
                foreach (var item in urunler)
                {
                    UrunListesi urun = new UrunListesi();
                    urun.Ad = item.Urun_Ad;
                    urun.Id = item.Urun_ID.ToString();
                    uruns.Add(urun);
                }
                return Ok(uruns);
            }
            catch (Exception ex)
            {
                return Ok();
            }

        }
    }
}
