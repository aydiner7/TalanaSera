using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TalanaWebApi.Models.dto
{
    public class SeraAyar
    {
        public string maxDeger { get; set; }
        public string minDeger { get; set; }
        public string maxAralik { get; set; }
        public string minAralik { get; set; }
        
        public string hedefDeger { get; set; }
        public string cumle1 { get; set; }
        public string cumle2 { get; set; }
    }
}