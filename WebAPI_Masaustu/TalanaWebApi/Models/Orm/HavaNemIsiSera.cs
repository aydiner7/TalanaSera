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
    
    public partial class HavaNemIsiSera
    {
        public int HavaNemIsiSera_ID { get; set; }
        public int HavaNemIsi_ID { get; set; }
        public int Sera_ID { get; set; }
        public System.DateTime HavaNemIsiSera_Tarih { get; set; }
    
        public virtual HavaNemIsi HavaNemIsi { get; set; }
        public virtual Seralar Seralar { get; set; }
    }
}
