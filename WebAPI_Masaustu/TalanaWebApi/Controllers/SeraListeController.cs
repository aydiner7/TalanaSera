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
    public class SeraListeController : ApiController
    {
        TalanaEntities db = new TalanaEntities();
        [HttpGet]
        public IHttpActionResult hr (string kod)
        {
            try
            {
                List<Sera> seras = new List<Sera>();
                var listem = db.Seralar.Where(s=>s.Sera_Aktif == true && s.Kullanicilar.Kullanici_Kod == kod).ToList();
                foreach (var item in listem)
                {  
                    Sera sera = new Sera();
                    sera.Id = item.Sera_ID.ToString();
                    var kontrolListe = db.SeraUrun.Where(m => m.Sera_ID == item.Sera_ID).FirstOrDefault();
                    if (kontrolListe == null)
                    {
                        sera.Resim = "bosSera.png";
                        sera.Tarih = "--.--.----";
                        sera.UrunAdi = "Sera Boş";
                    }
                    else
                    {
                        sera.Tarih = kontrolListe.Sera_HasatTarih.ToShortDateString();
                        var resimSorgu = db.Urunler.Where(u => u.Urun_ID == kontrolListe.Urun_ID).FirstOrDefault();
                        if (resimSorgu == null)
                        {
                            sera.Resim = "bosSera.png";
                            sera.UrunAdi = "Sera Boş";
                        }
                        else
                        {
                            sera.Resim = resimSorgu.Urun_Resim;
                            sera.UrunAdi = resimSorgu.Urun_Ad;
                        }

                    }
                    
                    sera.Ad = item.Sera_Ad;
                    seras.Add(sera);
                }

                return Ok(seras);
            }
            catch (Exception ex)
            {

                return Ok();

            }
        }
    }
}
