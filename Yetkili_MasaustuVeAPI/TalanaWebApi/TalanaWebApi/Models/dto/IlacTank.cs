using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TalanaWebApi.Models.dto
{
    public class IlacTank
    {
        public string ID { get; set; }
        public string IlacAdi { get; set; }
        public string Kapasite { get; set; }
        public string Doluluk { get; set; }
    }
}