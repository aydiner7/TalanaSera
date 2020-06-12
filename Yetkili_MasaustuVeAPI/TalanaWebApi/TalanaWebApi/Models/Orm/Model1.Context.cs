﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TalanaEntities : DbContext
    {
        public TalanaEntities()
            : base("name=TalanaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BildirimDurum> BildirimDurum { get; set; }
        public virtual DbSet<DisOrtam> DisOrtam { get; set; }
        public virtual DbSet<DisOrtamLog> DisOrtamLog { get; set; }
        public virtual DbSet<DisOrtamSera> DisOrtamSera { get; set; }
        public virtual DbSet<Fan> Fan { get; set; }
        public virtual DbSet<FanLog> FanLog { get; set; }
        public virtual DbSet<FanSera> FanSera { get; set; }
        public virtual DbSet<HavaKalite> HavaKalite { get; set; }
        public virtual DbSet<HavaKaliteLog> HavaKaliteLog { get; set; }
        public virtual DbSet<HavaKaliteSera> HavaKaliteSera { get; set; }
        public virtual DbSet<HavaNemIsi> HavaNemIsi { get; set; }
        public virtual DbSet<HavaNemIsiLog> HavaNemIsiLog { get; set; }
        public virtual DbSet<HavaNemIsiSera> HavaNemIsiSera { get; set; }
        public virtual DbSet<Ilac> Ilac { get; set; }
        public virtual DbSet<IlacMotor> IlacMotor { get; set; }
        public virtual DbSet<IlacMotorLog> IlacMotorLog { get; set; }
        public virtual DbSet<IlacMotorTankSera> IlacMotorTankSera { get; set; }
        public virtual DbSet<IlacTank> IlacTank { get; set; }
        public virtual DbSet<Isik> Isik { get; set; }
        public virtual DbSet<IsikLog> IsikLog { get; set; }
        public virtual DbSet<IsikSera> IsikSera { get; set; }
        public virtual DbSet<IsikSiddet> IsikSiddet { get; set; }
        public virtual DbSet<IsikSiddetLog> IsikSiddetLog { get; set; }
        public virtual DbSet<IsikSiddetSera> IsikSiddetSera { get; set; }
        public virtual DbSet<Kullanicilar> Kullanicilar { get; set; }
        public virtual DbSet<KullaniciLog> KullaniciLog { get; set; }
        public virtual DbSet<SeraKullanici> SeraKullanici { get; set; }
        public virtual DbSet<Seralar> Seralar { get; set; }
        public virtual DbSet<SeraUrun> SeraUrun { get; set; }
        public virtual DbSet<SuMotor> SuMotor { get; set; }
        public virtual DbSet<SuMotorLog> SuMotorLog { get; set; }
        public virtual DbSet<SuMotorSera> SuMotorSera { get; set; }
        public virtual DbSet<ToprakNem> ToprakNem { get; set; }
        public virtual DbSet<ToprakNemLog> ToprakNemLog { get; set; }
        public virtual DbSet<ToprakNemSera> ToprakNemSera { get; set; }
        public virtual DbSet<Urunler> Urunler { get; set; }
        public virtual DbSet<UrunOzellik> UrunOzellik { get; set; }
        public virtual DbSet<AnalizGrafikViews> AnalizGrafikViews { get; set; }
    }
}
