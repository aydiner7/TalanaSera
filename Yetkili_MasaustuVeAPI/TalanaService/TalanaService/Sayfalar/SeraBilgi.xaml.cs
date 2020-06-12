using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TalanaService.Models;

namespace TalanaService.Sayfalar
{
    /// <summary>
    /// SeraBilgi.xaml etkileşim mantığı
    /// </summary>
    public partial class SeraBilgi : Page
    {
        public List<FanVeriListe> FanVeri { get; set; }
        public List<HavaKaliteVeriListe> HavaKaliteVeri { get; set; }
        public List<IlaclamaVeriListe> IlaclamaVeri { get; set; }
        public List<IsikVeriListe> IsikVeri { get; set; }
        public List<IsiNemVeriListe> IsiNemVeri { get; set; }
        public List<SuMotorVeriListe> SuMotorVeri { get; set; }
        public List<ToprakNemVeriListe> ToprakNemVeri { get; set; }
        public SeraBilgi(string SeraID)
        {
            InitializeComponent();

            FanVeri = new List<FanVeriListe>();
            HavaKaliteVeri = new List<HavaKaliteVeriListe>();
            IlaclamaVeri = new List<IlaclamaVeriListe>();
            IsikVeri = new List<IsikVeriListe>();
            IsiNemVeri = new List<IsiNemVeriListe>();
            SuMotorVeri = new List<SuMotorVeriListe>();
            ToprakNemVeri = new List<ToprakNemVeriListe>();

            string url = "http://" + App.Current.Properties["Sunucu"].ToString() + ":44444/api/SeraIcerik?id="+SeraID;

            var client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string gelen = client.DownloadString(url);
            JObject jObject = JObject.Parse(gelen);

          

            var veriler = JArray.Parse(jObject["liste"].ToString());
            foreach (var item in veriler)
            {
                JObject jObject1 = JObject.Parse(item.ToString());
                FanVeriListe deger = new FanVeriListe();
                deger.IsiAkim = jObject1["IsiAkim"].ToString();
                deger.IsiPwmDeger = jObject1["IsiPwmDeger"].ToString();
                deger.FanAkim = jObject1["FanAkim"].ToString();
                deger.IsiAkim = jObject1["IsiAkim"].ToString();
                deger.SicaklikDeger = jObject1["SicaklikDeger"].ToString();
                deger.SicaklikAkim = jObject1["SicaklikAkim"].ToString();
                deger.Tarih = jObject1["Tarih"].ToString();
                FanVeri.Add(deger);
            }

            var veriler2 = JArray.Parse(jObject["liste1"].ToString());
            foreach (var item in veriler2)
            {
                JObject jObject1 = JObject.Parse(item.ToString());
                HavaKaliteVeriListe deger = new HavaKaliteVeriListe();
                deger.Akim = jObject1["Akim"].ToString();
                deger.Deger = jObject1["Deger"].ToString();
                deger.Tarih = jObject1["Tarih"].ToString();
                HavaKaliteVeri.Add(deger);
            }

            var veriler3 = JArray.Parse(jObject["liste2"].ToString());
            foreach (var item in veriler3)
            {
                JObject jObject1 = JObject.Parse(item.ToString());
                IlaclamaVeriListe deger = new IlaclamaVeriListe();
                deger.AkisDeger = jObject1["AkisDeger"].ToString();
                deger.MotorAkim = jObject1["MotorAkim"].ToString();
                deger.PwmDeger = jObject1["PwmDeger"].ToString();
                deger.Tarih = jObject1["Tarih"].ToString();
                IlaclamaVeri.Add(deger);
            }

            var veriler4 = JArray.Parse(jObject["liste3"].ToString());
            foreach (var item in veriler4)
            {
                JObject jObject1 = JObject.Parse(item.ToString());
                IsikVeriListe deger = new IsikVeriListe();
                deger.Akim = jObject1["Akim"].ToString();
                deger.Deger = jObject1["Deger"].ToString();
                deger.Tarih = jObject1["Tarih"].ToString();
                IsikVeri.Add(deger);
            }

            var veriler5 = JArray.Parse(jObject["liste4"].ToString());
            foreach (var item in veriler5)
            {
                JObject jObject1 = JObject.Parse(item.ToString());
                IsiNemVeriListe deger = new IsiNemVeriListe();
                deger.Akim = jObject1["Akim"].ToString();
                deger.IsiDeger = jObject1["IsiDeger"].ToString();
                deger.NemDeger = jObject1["NemDeger"].ToString();
                deger.Tarih = jObject1["Tarih"].ToString();
                IsiNemVeri.Add(deger);
            }

            var veriler6 = JArray.Parse(jObject["liste5"].ToString());
            foreach (var item in veriler6)
            {
                JObject jObject1 = JObject.Parse(item.ToString());
                SuMotorVeriListe deger = new SuMotorVeriListe();
                deger.AkisDeger = jObject1["AkisDeger"].ToString();
                deger.BasincDeger = jObject1["BasincDeger"].ToString();
                deger.MotorAkim = jObject1["MotorAkim"].ToString();
                deger.PwmDeger = jObject1["PwmDeger"].ToString();
                deger.Tarih = jObject1["Tarih"].ToString();
                SuMotorVeri.Add(deger);
            }

            var veriler7 = JArray.Parse(jObject["liste6"].ToString());
            foreach (var item in veriler7)
            {
                JObject jObject1 = JObject.Parse(item.ToString());
                ToprakNemVeriListe deger = new ToprakNemVeriListe();
                deger.Akim = jObject1["Akim"].ToString();
                deger.Deger = jObject1["Deger"].ToString();
                deger.Tarih = jObject1["Tarih"].ToString();
                ToprakNemVeri.Add(deger);
            }

            JObject durum = JObject.Parse(jObject["durum"].ToString());
            sn.icerik = durum["sicaklik"].ToString() + " / " + durum["nem"].ToString();
            hi.icerik = durum["hava"].ToString() + " / " + durum["isik"].ToString();

            DataContext = this;
        }
    }
}
