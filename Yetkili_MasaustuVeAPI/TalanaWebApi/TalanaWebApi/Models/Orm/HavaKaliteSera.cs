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
    
    public partial class HavaKaliteSera
    {
        public int HavaKaliteSera_ID { get; set; }
        public int HavaKalite_ID { get; set; }
        public int Sera_ID { get; set; }
        public System.DateTime HavaKaliteSera_Tarih { get; set; }
    
        public virtual HavaKalite HavaKalite { get; set; }
        public virtual Seralar Seralar { get; set; }
    }
}
