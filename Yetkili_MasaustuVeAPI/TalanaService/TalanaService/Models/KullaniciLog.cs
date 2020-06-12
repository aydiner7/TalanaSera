using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalanaService.Models
{
    public class KullaniciLog
    {
        public string Kullanici_Sifre { get; set; }
        public string Girilen_Sifre { get; set; }
        public string Platform { get; set; }
        public string Ip { get; set; }
        public string Tarih { get; set; }
    }
}
