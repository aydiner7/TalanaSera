using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TalanaWebApi.Models.dto
{
    public class KullaniciBilgiListe
    {
        public List<Models.dto.KullaniciLog> liste { get; set; }
        public KullaniciListe kullaniciListe { get; set; }
    }
}