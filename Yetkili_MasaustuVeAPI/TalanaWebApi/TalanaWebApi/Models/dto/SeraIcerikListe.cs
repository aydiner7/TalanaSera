using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TalanaService.Models;

namespace TalanaWebApi.Models.dto
{
    public class SeraIcerikListe
    {
        public List<FanVeriListe> liste { get; set; }
        public List<HavaKaliteVeriListe> liste1 { get; set; }
        public List<IlaclamaVeriListe> liste2 { get; set; }
        public List<IsikVeriListe> liste3 { get; set; }
        public List<IsiNemVeriListe> liste4 { get; set; }
        public List<SuMotorVeriListe> liste5 { get; set; }
        public List<ToprakNemVeriListe> liste6 { get; set; }
        public SeraDurum durum { get; set; }
    }
}