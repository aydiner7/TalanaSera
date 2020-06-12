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
    public class AnalizGrafikController : ApiController
    {
        TalanaEntities db = new TalanaEntities();
        [HttpGet]
        public IHttpActionResult httpAction()
        {
            try
            {
                var grafik = db.AnalizGrafikViews.ToList();
                return Ok(grafik);
            }
            catch (Exception ex)
            {
                return Ok();
            }
        }
    }
}
