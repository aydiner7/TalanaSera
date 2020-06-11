using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TalanaWebApi.Models.dto
{
    public class BildirimListe
    {
        public string Olay_Adi { get; set; }
        public string Sera_Adi { get; set; }

        public string Tarih { get; set; }
        public string Resim { get; set; }

        public string Bas_Saat { get; set; }
        public string Bit_Saat { get; set; }
        public string Eski_Olay { get; set; }
        public string Yeni_Olay { get; set; }


    }
}