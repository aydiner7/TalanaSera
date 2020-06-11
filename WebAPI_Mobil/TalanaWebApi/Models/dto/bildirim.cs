using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TalanaWebApi.Models.dto
{
    public class bildirim
    {
        public string Bildirim_ID { get; set; }
        public string Olay_Adi { get; set; }
        public string Sera_Adi { get; set; }
        public string Tarih { get; set; }
        public string Baslangic_Saat { get; set; }
        public string Bitis_Saat { get; set; }

    }
}