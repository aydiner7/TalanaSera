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
    public class BildirimController : ApiController
    {
        TalanaEntities db = new TalanaEntities();
        [HttpGet]
        public IHttpActionResult HttpAction()
        {
            try
            {
                List<BildirimListe> bildirims = new List<BildirimListe>();
                DateTime baslangicTarih = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                DateTime bitisTarih = Convert.ToDateTime(DateTime.Now.ToShortDateString()).AddDays(1);
                var bildirim = db.BildirimDurum.Where(s=>s.Tarih<bitisTarih && s.Tarih>=baslangicTarih).ToList();
                foreach (var item in bildirim)
                {
                    BildirimListe bildirimListe = new BildirimListe();
                    bildirimListe.Olay_Adi = item.Olay_Adi;
                    bildirimListe.Sera_Adi = item.Sera_Adi;
                    bildirimListe.Resim = item.Resim;
                    bildirimListe.Tarih = item.Tarih.ToShortDateString();
                    bildirimListe.Eski_Olay = item.Eski_Olay;
                    bildirimListe.Yeni_Olay = item.Yeni_Olay;
                    bildirimListe.Bas_Saat = item.Baslangic_Saat;
                    bildirimListe.Bit_Saat = item.Bitis_Saat;
                    bildirims.Add(bildirimListe);
                }

                return Ok(bildirims);
            }
            catch (Exception ex)
            {
                return Ok();
            }

        }

        [HttpGet]
        public IHttpActionResult HttpAction(string tarih1,string tarih2)
        {
            try
            {
                List<BildirimListe> bildirims = new List<BildirimListe>();
                DateTime baslangicTarih = Convert.ToDateTime(tarih1);
                DateTime bitisTarih = Convert.ToDateTime(tarih2).AddDays(1);
                var bildirim = db.BildirimDurum.Where(s => s.Tarih < bitisTarih && s.Tarih >= baslangicTarih).OrderByDescending(t=>t.Tarih).ToList();
                foreach (var item in bildirim)
                {
                    BildirimListe bildirimListe = new BildirimListe();
                    bildirimListe.Olay_Adi = item.Olay_Adi;
                    bildirimListe.Sera_Adi = item.Sera_Adi;
                    bildirimListe.Resim = item.Resim;
                    bildirimListe.Tarih = item.Tarih.ToShortDateString();
                    bildirimListe.Eski_Olay = item.Eski_Olay;
                    bildirimListe.Yeni_Olay = item.Yeni_Olay;
                    bildirimListe.Bas_Saat = item.Baslangic_Saat;
                    bildirimListe.Bit_Saat = item.Bitis_Saat;
                    bildirims.Add(bildirimListe);
                }

                return Ok(bildirims);
            }
            catch (Exception ex)
            {
                return Ok();
            }

        }

    }
}
