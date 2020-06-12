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
    public class IlacListeController : ApiController
    {
        TalanaEntities db = new TalanaEntities();
        [HttpGet]
        public IHttpActionResult httpActionResult()
        {
            try
            {
                List<IlacListe> listes = new List<IlacListe>();
                var gelen = db.Ilac.ToList();
                foreach (var item in gelen)
                {
                    IlacListe liste = new IlacListe();
                    liste.ID = item.Ilac_ID.ToString();
                    liste.AD = item.Ilac_Ad;
                    listes.Add(liste);
                }
                return Ok(listes);
            }
            catch (Exception ex)
            {
                return Ok();
            }
        }
    }
}
