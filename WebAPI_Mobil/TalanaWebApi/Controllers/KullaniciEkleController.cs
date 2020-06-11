using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TalanaWebApi.Models;
using TalanaWebApi.Models.Orm;

namespace TalanaWebApi.Controllers
{
    public class KullaniciEkleController : ApiController
    {
        TalanaEntities db = new TalanaEntities();
        [HttpGet]
        public string KullaniciOlustur(String Ad,String Soyad,String Sifre,String Resim)
        {
            try
            {
                return Resim;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
