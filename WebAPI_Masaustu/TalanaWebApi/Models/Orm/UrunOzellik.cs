//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TalanaWebApi.Models.Orm
{
    using System;
    using System.Collections.Generic;
    
    public partial class UrunOzellik
    {
        public int UrunOzellik_ID { get; set; }
        public int Urun_ID { get; set; }
        public string UrunOzellik_MinSicaklik { get; set; }
        public string UrunOzellik_MaxSicaklik { get; set; }
        public string UrunOzellik_MinNem { get; set; }
        public string UrunOzellik_MaxNem { get; set; }
        public string UrunOzellik_MinToprakNem { get; set; }
        public string UrunOzellik_MaxToprakNem { get; set; }
        public string UrunOzellik__MinIsikSiddet { get; set; }
        public string UrunOzellik_MaxIsikSiddet { get; set; }
        public string UrunOzellik_MinHavaKalite { get; set; }
        public string UrunOzellik_MaxHavaKalite { get; set; }
        public string UrunOzellik_IlacSure { get; set; }
        public string UrunOzellik_IlacMiktar { get; set; }
        public string UrunOzellik_HasatSure { get; set; }
        public System.DateTime UrunOzellik_Tarih { get; set; }
    
        public virtual Urunler Urunler { get; set; }
    }
}
