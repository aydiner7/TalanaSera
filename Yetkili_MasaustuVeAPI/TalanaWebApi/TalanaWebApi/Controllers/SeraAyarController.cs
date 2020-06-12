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
    public class SeraAyarController : ApiController
    {
        TalanaEntities db = new TalanaEntities();
        [HttpGet]
        public IHttpActionResult httpAction(String Tur,String SeraID)
        {
            try
            {
                SeraAyar ayar = new SeraAyar();
                int sID = Convert.ToInt32(SeraID);
                var UID = db.SeraUrun.Where(s => s.Sera_ID == sID).FirstOrDefault();
                var ozellik = db.UrunOzellik.Where(s => s.Urun_ID == UID.Urun_ID).FirstOrDefault();
                if(Tur == "Sicaklik")
                {
                    ayar.maxAralik = ozellik.UrunOzellik_MaxSicaklik;
                    ayar.minAralik = ozellik.UrunOzellik_MinSicaklik;
                    ayar.maxDeger = UID.MaxSicaklik;
                    ayar.minDeger = UID.MinSicaklik;
                    ayar.hedefDeger = UID.HedefSicaklik;
                    ayar.cumle1 = UID.SicaklikCumle1;
                    ayar.cumle2 = UID.SicaklikCumle2;

                }
                else if (Tur == "Hava")
                {
                    ayar.maxAralik = ozellik.UrunOzellik_MaxHavaKalite;
                    ayar.minAralik = ozellik.UrunOzellik_MinHavaKalite;
                    ayar.maxDeger = UID.MaxHava;
                    ayar.minDeger = UID.MinHava;
                    ayar.hedefDeger = UID.HedefHava;
                    ayar.cumle1 = UID.HavaCumle1;
                    ayar.cumle2 = UID.HavaCumle2;

                }
                else if (Tur == "Nem")
                {
                    ayar.maxAralik = ozellik.UrunOzellik_MaxNem;
                    ayar.minAralik = ozellik.UrunOzellik_MinNem;
                    ayar.maxDeger = UID.MaxNem;
                    ayar.minDeger = UID.MinNem;
                    ayar.hedefDeger = UID.HedefNem;
                    ayar.cumle1 = UID.NemCumle1;
                    ayar.cumle2 = UID.NemCumle2;

                }
                else if (Tur == "Isik")
                {
                    ayar.maxAralik = ozellik.UrunOzellik_MaxIsikSiddet;
                    ayar.minAralik = ozellik.UrunOzellik__MinIsikSiddet;
                    ayar.maxDeger = UID.MaxIsik;
                    ayar.minDeger = UID.MinIsik;
                    ayar.hedefDeger = UID.HedefIsik;
                    ayar.cumle1 = UID.IsikCumle1;
                    ayar.cumle2 = UID.IsikCumle2;

                }
                return Ok(ayar);
            }
            catch (Exception ex)
            {
                return Ok();
            }
        }
    }
}
