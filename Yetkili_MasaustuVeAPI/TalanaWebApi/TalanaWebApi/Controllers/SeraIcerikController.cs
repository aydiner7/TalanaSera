using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TalanaService.Models;
using TalanaWebApi.Models.dto;
using TalanaWebApi.Models.Orm;

namespace TalanaWebApi.Controllers
{
    public class SeraIcerikController : ApiController
    {
        TalanaEntities db = new TalanaEntities();
        [HttpGet]
        public IHttpActionResult httpActionResult(string id)
        {
            try
            {
                SeraIcerikListe seraIcerikListe = new SeraIcerikListe();
                List<FanVeriListe> liste = new List<FanVeriListe>();
                List<HavaKaliteVeriListe> liste1 = new List<HavaKaliteVeriListe>();
                List<IlaclamaVeriListe> liste2 = new List<IlaclamaVeriListe>();
                List<IsikVeriListe> liste3 = new List<IsikVeriListe>();
                List<IsiNemVeriListe> liste4 = new List<IsiNemVeriListe>();
                List<SuMotorVeriListe> liste5 = new List<SuMotorVeriListe>();
                List<ToprakNemVeriListe> liste6 = new List<ToprakNemVeriListe>();
                int sID = Convert.ToInt32(id);
                var seram = db.SeraUrun.Where(s => s.Sera_ID == sID).FirstOrDefault();
                SeraDurum durum = new SeraDurum();
                durum.hava = seram.HedefHava;
                durum.isik = seram.HedefIsik;
                durum.sicaklik = seram.HedefSicaklik;
                durum.nem = seram.HedefNem;

                var veriler = db.FanLog.ToList();
                foreach (var item in veriler)
                {
                    FanVeriListe deger = new FanVeriListe();
                    deger.IsiAkim = item.FanLog_IsiAkim;
                    deger.IsiPwmDeger = item.FanLog_IsıPwmDeger;
                    deger.FanAkim = item.FanLog_FanAkim.ToString();
                    deger.IsiAkim = item.FanLog_IsiAkim;
                    deger.SicaklikDeger = item.FanLog_SicaklikDeger;
                    deger.SicaklikAkim = item.FanLog_SicaklikAkim;
                    deger.Tarih = item.FanLog_Tarih.ToString();
                    liste.Add(deger);
                }

                var veriler2 = db.HavaKaliteLog.ToList();
                foreach (var item in veriler2)
                {
                    HavaKaliteVeriListe deger = new HavaKaliteVeriListe();
                    deger.Akim = item.HavaKaliteLog_Akim;
                    deger.Deger = item.HavaKaliteLog_Deger;
                    deger.Tarih = item.HavaKaliteLog_Tarih.ToString();
                    liste1.Add(deger);
                }

                var veriler3 = db.IlacMotorLog.ToList();
                foreach (var item in veriler3)
                {
                    IlaclamaVeriListe deger = new IlaclamaVeriListe();
                    deger.AkisDeger = item.IlacMotorLog_AkisDeger;
                    deger.MotorAkim = item.IlacMotorLog_MotorAkim.ToString();
                    deger.PwmDeger = item.IlacMotorLog_PwmDeger;
                    deger.Tarih = item.IlacMotorLog_Tarih.ToString();
                    liste2.Add(deger);
                }

                var veriler4 = db.IsikLog.ToList();
                foreach (var item in veriler4)
                {
                    IsikVeriListe deger = new IsikVeriListe();
                    deger.Akim = item.IsikLog_Akim;
                    deger.Deger = item.IsikLog_Deger;
                    deger.Tarih = item.IsikLog_Tarih.ToString();
                    liste3.Add(deger);
                }

                var veriler5 = db.HavaNemIsiLog.ToList();
                foreach (var item in veriler5)
                {
                    IsiNemVeriListe deger = new IsiNemVeriListe();
                    deger.Akim = item.HavaNemIsiLog_Akim;
                    deger.IsiDeger = item.HavaNemIsiLog_IsiDeger;
                    deger.NemDeger = item.HavaNemIsiLog_NemDeger;
                    deger.Tarih = item.HavaNemIsiLog_Tarih.ToString();
                    liste4.Add(deger);
                }

                var veriler6 = db.SuMotorLog.ToList();
                foreach (var item in veriler6)
                {
                    SuMotorVeriListe deger = new SuMotorVeriListe();
                    deger.AkisDeger = item.SuMotorLog_AkisDeger;
                    deger.BasincDeger = item.SuMotorLog_BasincDeger;
                    deger.MotorAkim = item.SuMotorLog_MotorAkim.ToString();
                    deger.PwmDeger = item.SuMotorLog_PwmDeger;
                    deger.Tarih = item.SuMotorLog_Tarih.ToString();
                    liste5.Add(deger);
                }

                var veriler7 = db.ToprakNemLog.ToList();
                foreach (var item in veriler7)
                {
                    ToprakNemVeriListe deger = new ToprakNemVeriListe();
                    deger.Akim = item.ToprakNemLog_Akim;
                    deger.Deger = item.ToprakNemLog_Deger;
                    deger.Tarih = item.ToprakNemLog_Tarih.ToString();
                    liste6.Add(deger);
                }

                seraIcerikListe.durum = durum;
                seraIcerikListe.liste = liste;
                seraIcerikListe.liste1 = liste1;
                seraIcerikListe.liste2 = liste2;
                seraIcerikListe.liste3 = liste3;
                seraIcerikListe.liste4 = liste4;
                seraIcerikListe.liste5 = liste5;
                seraIcerikListe.liste6 = liste6;

                return Ok(seraIcerikListe);
            }
            catch (Exception ex)
            {
                return Ok();
            }
        }
    }
}
