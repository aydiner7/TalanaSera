using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sera
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SeraAyar : ContentPage
    {
        string sTur, sSeraID;
        public SeraAyar(string id,string tur)
        {
            InitializeComponent();
            sTur = tur;
            sSeraID = id;
            WebClient client1 = new WebClient();
            String url1 = "http://192.168.0.10:44444/api/AnlikDurum/?seraID=" + id;
            string gelen1 = client1.DownloadString(url1);
            JObject jObject1 = JObject.Parse(gelen1);
            dDerece.Text = jObject1["Sicaklik"].ToString() + " °C";
            dHava.Text = jObject1["Hava"].ToString() + " (PM2.5)";
            dNem.Text = jObject1["Nem"].ToString() + "%";
            dIsik.Text = jObject1["Isik"].ToString() + " CD";


            try
            {
                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;
                String url = "http://192.168.0.10:44444/api/SeraAyar/?Tur=" + tur + "&SeraID=" + id;
                string gelen = client.DownloadString(url);
                JObject jObject = JObject.Parse(gelen);
                SeraCumle1.Text = jObject["cumle1"].ToString();
                SeraCumle2.Text = jObject["cumle2"].ToString();
                slider.Value = Convert.ToInt32(jObject["hedefDeger"].ToString());
                slider.Minimum = Convert.ToInt32(jObject["minAralik"].ToString());
                slider.Maximum = Convert.ToInt32(jObject["maxAralik"].ToString());

                RangeSlider.MinimumValue = Convert.ToInt32(jObject["minAralik"].ToString());
                RangeSlider.MaximumValue = Convert.ToInt32(jObject["maxAralik"].ToString());

                RangeSlider.LowerValue = Convert.ToInt32(jObject["minDeger"].ToString());
                RangeSlider.UpperValue = Convert.ToInt32(jObject["maxDeger"].ToString());
           
            }
            catch (Exception ex)
            {
                slider.Value = 0;
                slider.Minimum = 0;
                slider.Maximum = 0;
                RangeSlider.MinimumValue = 0;
                RangeSlider.MaximumValue = 0;
                RangeSlider.LowerValue = 0;
                RangeSlider.UpperValue = 0;
            }
            upperc.Text = RangeSlider.UpperValue.ToString();
            lowerc.Text = RangeSlider.LowerValue.ToString();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Slider slider = (Slider)sender;
            var newStep = Math.Round(e.NewValue / 1);

            slider.Value = newStep * 1;
            deger.Text = slider.Value.ToString();
        }

        private void RangeSlider_LowerValueChanged(object sender, EventArgs e)
        {
            lowerc.Text = RangeSlider.LowerValue.ToString();
        }

        private void RangeSlider_UpperValueChanged(object sender, EventArgs e)
        {
            upperc.Text = RangeSlider.UpperValue.ToString();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            WebClient webclient1 = new WebClient();
            webclient1.Encoding = Encoding.UTF8;
            String url1 = "http://192.168.0.10:44444/api/SeraAyarUpdate/?Tur=" + sTur + "&SeraID=" + sSeraID + "&maxDeger=" + RangeSlider.UpperValue.ToString() + "&minDeger=" + RangeSlider.LowerValue.ToString();
            string gelenDeger1 = webclient1.DownloadString(url1);
            

            WebClient webclient = new WebClient();
            webclient.Encoding = Encoding.UTF8;
            String url = "http://192.168.0.10:44444/api/HedefUpdate/?tur=" + sTur + "&SeraID=" + sSeraID + "&deger=" + slider.Value.ToString();
            string gelenDeger = webclient.DownloadString(url);
            if (gelenDeger == "1" && gelenDeger1 == "1")
              await DisplayAlert("Uyari", sTur + " degerleri Güncellendi", "Tamam");
            else
              await  DisplayAlert("Uyari", "hata oluştu", "Tamam");

        }
    }
}