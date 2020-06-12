using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace TalanaService.Models
{
    public class Kullanici
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Kod { get; set; }
        public ImageSource Resim { get; set; }
        public DateTime Tarih { get; set; }
    }
}
