using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TalanaWebApi.Models.Orm;

namespace TalanaWebApi.Controllers
{
    public class SeraEkleController : ApiController
    {
        TalanaEntities db = new TalanaEntities();
        [HttpGet]
        public IHttpActionResult httpActionResult(string SeraAdi, string DisOrtamAdi , string kID ,string IlactankID, string SuMotorAdi, string IlacMotorAdi, string IsikSiddetAdi, string IsikKaynakAdi, string tnsAdi, string hnsAdi, string hksAdi, string fanAdi)
        {
            try
            {
                Seralar seralar = new Seralar();
                seralar.Sera_Kullanici_ID = Convert.ToInt32(kID);
                seralar.Sera_Ad = SeraAdi;
                seralar.Sera_Tarih = DateTime.Now;
                seralar.Sera_Aktif = true;
                db.Seralar.Add(seralar);
                db.SaveChanges();

                Fan fan = new Fan();
                fan.Fan_Ad = fanAdi;
                fan.Fan_Tarih = DateTime.Now;
                fan.Fan_Aktif = true;
                db.Fan.Add(fan);
                db.SaveChanges();

                DisOrtam dis = new DisOrtam();
                dis.DisOrtam_Ad = DisOrtamAdi;
                dis.DisOrtam_Tarih = DateTime.Now;
                dis.DisOrtam_Aktif = true;
                db.DisOrtam.Add(dis);
                db.SaveChanges();

                HavaKalite hava = new HavaKalite();
                hava.HavaKalite_Ad = hksAdi;
                hava.HavaKalite_Tarih = DateTime.Now;
                hava.HavaKalite_Aktif = true;
                db.HavaKalite.Add(hava);
                db.SaveChanges();

                HavaNemIsi havaNem = new HavaNemIsi();
                havaNem.HavaNemIsi_Ad = fanAdi;
                havaNem.HavaNemIsi_Tarih = DateTime.Now;
                havaNem.HavaNemIsi_Aktif = true;
                db.HavaNemIsi.Add(havaNem);
                db.SaveChanges();

                IlacMotor ilacmotor = new IlacMotor();
                ilacmotor.IlacMotor_Ad = IlacMotorAdi;
                ilacmotor.IlacMotor_Tarih = DateTime.Now;
                ilacmotor.IlacMotor_Aktif = true;
                db.IlacMotor.Add(ilacmotor);
                db.SaveChanges();

                Isik isik = new Isik();
                isik.Isik_Ad = IsikKaynakAdi;
                isik.Isik_Tarih = DateTime.Now;
                isik.Isik_Aktif = true;
                db.Isik.Add(isik);
                db.SaveChanges();

                IsikSiddet isikSiddet = new IsikSiddet();
                isikSiddet.IsikSiddet_Ad = IsikSiddetAdi;
                isikSiddet.IsikSiddet_Tarih = DateTime.Now;
                isikSiddet.IsikSiddet_Aktif = true;
                db.IsikSiddet.Add(isikSiddet);
                db.SaveChanges();

                SuMotor suMotor = new SuMotor();
                suMotor.SuMotor_Ad = SuMotorAdi;
                suMotor.SuMotor_Tarih = DateTime.Now;
                suMotor.SuMotor_Aktif = true;
                db.SuMotor.Add(suMotor);
                db.SaveChanges();

                ToprakNem toprak = new ToprakNem();
                toprak.ToprakNem_Ad = tnsAdi;
                toprak.ToprakNem_Tarih = DateTime.Now;
                toprak.ToprakNem_Aktif = true;
                db.ToprakNem.Add(toprak);
                db.SaveChanges();

                return Ok(true);
            }
            catch (Exception ex)
            {
                return Ok();
            }
        }
    }
}
