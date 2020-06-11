using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalanaSera.Models.dto
{
    class Urunler
    {
        public string Id { get; set; }
        public string Ad { get; set; }
        public Urunler(string Ids , string Ads)
        {
            Id = Ids;
            Ad = Ads;
        }
    }
}
