using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Media;

namespace TalanaWebApi.Models
{
    public class Kullanici
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Kod { get; set; }
        public string Resim { get; set; }
    }
}