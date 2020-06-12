using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TalanaWebApi.Models.dto
{
    public class KullaniciListe
    {
        public string Kullanici_ID { get; set; }
        public string Kullanici_Ad { get; set; }
        public string Kullanici_Soyad { get; set; }
        public string Kullanici_Resim { get; set; }
    }
}