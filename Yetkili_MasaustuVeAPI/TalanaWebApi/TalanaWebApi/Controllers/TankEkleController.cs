using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TalanaWebApi.Models.Orm;

namespace TalanaWebApi.Controllers
{
    public class TankEkleController : ApiController
    {
        TalanaEntities db = new TalanaEntities();
        [HttpGet]
        public IHttpActionResult KullaniciOlustur(String kapasite, String doluluk, String id)
        {

            try
            {
                IlacTank tank = new IlacTank();
                tank.IlacTank_AktifMiktar = doluluk;
                tank.IlacTank_MaxMiktar = kapasite;
                tank.Ilac_ID = Convert.ToInt32(id);
                tank.IlacTank_Tarih = DateTime.Now;
                db.IlacTank.Add(tank);
                db.SaveChanges();

                return Ok(true);
            }
            catch (Exception ex)
            {
                return Ok(false);
            }

        }
    }
}
