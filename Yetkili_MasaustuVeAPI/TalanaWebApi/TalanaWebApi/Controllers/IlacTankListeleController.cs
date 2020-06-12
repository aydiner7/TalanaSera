using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TalanaWebApi.Models.Orm;

namespace TalanaWebApi.Controllers
{
    public class IlacTankListeleController : ApiController
    {
        TalanaEntities db = new TalanaEntities();
        [HttpGet]
        public IHttpActionResult httpActionResult()
        {
            try
            {
                List<Models.dto.IlacTank> tanks = new List<Models.dto.IlacTank>();
                var veri = db.IlacTank.ToList();
                foreach (var item in veri)
                {
                    var ilac = db.Ilac.Where(s => s.Ilac_ID == item.Ilac_ID).FirstOrDefault();
                    Models.dto.IlacTank tank = new Models.dto.IlacTank();
                    tank.IlacAdi = ilac.Ilac_Ad;
                    tank.Kapasite = item.IlacTank_MaxMiktar;
                    tank.Doluluk = item.IlacTank_AktifMiktar;
                    tank.ID = item.IlacTank_ID.ToString();
                    tanks.Add(tank);
                }
                return Ok(tanks);
            }
            catch (Exception ex)
            {
                return Ok();
            }
        }
    }
}
