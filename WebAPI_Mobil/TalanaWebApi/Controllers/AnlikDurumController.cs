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
    public class AnlikDurumController : ApiController
    {
        TalanaEntities db = new TalanaEntities();
        [HttpGet]
        public IHttpActionResult SeraAnlikDeger(string seraID)
        {
            try
            {
                int sID = Convert.ToInt32(seraID);
                AnlikDeger anlik = new AnlikDeger();
                var sicaklikKontrol = db.HavaNemIsiSera.Where(s => s.Sera_ID == sID).ToList();
                int sicaklikComponentSayisi = 0;
                int sicaklikToplam = 0;
                foreach (var item in sicaklikKontrol)
                {
                    sicaklikComponentSayisi++;
                    var sicaklik = db.HavaNemIsiLog.Where(m => m.HavaNemIsi_ID == item.HavaNemIsi_ID).FirstOrDefault();
                    sicaklikToplam += Convert.ToInt32(sicaklik.HavaNemIsiLog_IsiDeger);

                }
                if (sicaklikComponentSayisi == 0)
                    anlik.Sicaklik = "-";
                else
                    anlik.Sicaklik = (sicaklikToplam / sicaklikComponentSayisi).ToString();


                var isikKontrol = db.IsikSera.Where(s => s.Sera_ID == sID).ToList();
                int isikComponentSayisi = 0;
                int isikToplam = 0;
                foreach (var item in isikKontrol)
                {
                    isikComponentSayisi++;
                    var isik = db.IsikLog.Where(m => m.Isik_ID == item.Isik_ID).FirstOrDefault();
                    isikToplam += Convert.ToInt32(isik.IsikLog_Deger);

                }
                if (isikComponentSayisi == 0)
                    anlik.Isik = "-";
                else
                    anlik.Isik = (isikToplam / isikComponentSayisi).ToString();

                var havaKontrol = db.HavaKaliteSera.Where(s => s.Sera_ID == sID).ToList();
                int havaComponentSayisi = 0;
                int havaToplam = 0;
                foreach (var item in havaKontrol)
                {
                    havaComponentSayisi++;
                    var hava = db.HavaKaliteLog.Where(m => m.HavaKalite_ID == item.HavaKalite_ID).FirstOrDefault();
                    havaToplam += Convert.ToInt32(hava.HavaKaliteLog_Deger);

                }
                if (havaComponentSayisi == 0)
                    anlik.Hava = "-";
                else
                    anlik.Hava = (havaToplam / havaComponentSayisi).ToString();

                var nemKontrol = db.ToprakNemSera.Where(s => s.Sera_ID == sID).ToList();
                int nemComponentSayisi = 0;
                int nemToplam = 0;
                foreach (var item in nemKontrol)
                {
                    nemComponentSayisi++;
                    var nem = db.ToprakNemLog.Where(m => m.ToprakNem_ID == item.ToprakNem_ID).FirstOrDefault();
                    nemToplam += Convert.ToInt32(nem.ToprakNemLog_Deger);

                }
                if (nemComponentSayisi == 0)
                    anlik.Nem = "-";
                else
                    anlik.Nem = (nemToplam / nemComponentSayisi).ToString();

                return Ok(anlik);

            }
            catch (Exception ex)
            {
                return Ok(); 
            }
        }
    }
}
