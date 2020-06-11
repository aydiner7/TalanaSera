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
    public partial class SeraIcerik : ContentPage
    {
        string SeraID;
        public SeraIcerik(string id)
        {
            InitializeComponent();
            SeraID = id;
            WebClient client = new WebClient();
            String url = "http://192.168.0.10:44444/api/AnlikDurum/?seraID=" + id;
            string gelen = client.DownloadString(url);
            JObject jObject = JObject.Parse(gelen);
            dDerece.Text = "↑ " + jObject["Sicaklik"].ToString()+ " °C";
            dHava.Text = "↓ "+ jObject["Hava"].ToString() + " (PM2.5)";
            dNem.Text = "↓ " + jObject["Nem"].ToString() + "%";
            dIsik.Text = "↑ " + jObject["Isik"].ToString() + " CD";
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Frame frame = (Frame)sender;
            StackLayout stack = (StackLayout)frame.Content;
            Label isim = (Label)stack.Children[0];
            SeraAyar seraAyar = new SeraAyar(SeraID,isim.Text);
            Anasayfa.orta.Children.Clear();
            Anasayfa.orta.Children.Add(seraAyar.Content);
        }
    }
}