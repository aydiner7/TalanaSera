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
    
    public partial class KullaniciLog
    {
        public int KullaniciLog_ID { get; set; }
        public int Kullanici_ID { get; set; }
        public string Kullanici_Sifre { get; set; }
        public string Girilen_Sifre { get; set; }
        public string Kullanici_Platform { get; set; }
        public string Kullanici_IP { get; set; }
        public System.DateTime KullaniciLog_Tarih { get; set; }
    
        public virtual Kullanicilar Kullanicilar { get; set; }
    }
}
