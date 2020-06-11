using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TalanaWebApi.Controllers
{
    public class BaglantiController : ApiController
    {
        [HttpGet]
        public bool GirisKontrol(String Kadi,String Sifre)
        {
            if (Kadi == "Talana" && Sifre == "Talana")
                return true;
            return false;
        }
    }
}
