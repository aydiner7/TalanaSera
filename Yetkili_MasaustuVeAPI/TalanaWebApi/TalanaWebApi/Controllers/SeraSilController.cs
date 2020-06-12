using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TalanaWebApi.Models.Orm;

namespace TalanaWebApi.Controllers
{
    public class SeraSilController : ApiController
    {
        TalanaEntities db = new TalanaEntities();
        [HttpDelete]
        public IHttpActionResult httpActionResult(string id)
        {
            try
            {
                int sID = Convert.ToInt32(id);
                Seralar seralar = db.Seralar.Where(s => s.Sera_ID == sID).FirstOrDefault();
                db.Seralar.Remove(seralar);
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
