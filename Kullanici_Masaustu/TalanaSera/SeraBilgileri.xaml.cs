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

namespace TalanaSera
{
    /// <summary>
    /// SeraBilgileri.xaml etkileşim mantığı
    /// </summary>
    public partial class SeraBilgileri : Page
    {
        public static Frame panel2;
        public SeraBilgileri(string id)
        {
            InitializeComponent();

            panel2 = seraAyar;

            WebClient client = new WebClient();
            String url = "http://" + App.Current.Properties["sunucu"].ToString() + ":44444/api/AnlikDurum/?seraID=" + id;
            string gelen = client.DownloadString(url);
            JObject jObject = JObject.Parse(gelen);
            dDerece.Ad = jObject["Sicaklik"].ToString();
            dHava.Ad = jObject["Hava"].ToString();
            dNem.Ad = jObject["Nem"].ToString();
            dIsik.Ad = jObject["Isik"].ToString();

            dDerece.SeraID = id;
            dHava.SeraID = id;
            dNem.SeraID = id;
            dIsik.SeraID = id;
        }

       
    }
}
