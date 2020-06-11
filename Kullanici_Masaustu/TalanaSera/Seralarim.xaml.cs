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
    /// Seralarim.xaml etkileşim mantığı
    /// </summary>
    public partial class Seralarim : Page
    {
        public Seralarim()
        {
            InitializeComponent();

            try
            {
                WebClient veriCek = new WebClient();
                veriCek.Encoding = Encoding.UTF8;
                String url = "http://" + App.Current.Properties["sunucu"].ToString() + ":44444/api/SeraListe/?kod=" + App.Current.Properties["kullaniciKodu"].ToString();
                string gelen = veriCek.DownloadString(url);
                JArray jArray = JArray.Parse(gelen);
                foreach (var item in jArray)
                {
                    JObject jObject = JObject.Parse(item.ToString());
                    StackPanel stackPanel1 = new StackPanel
                    {
                        Orientation = Orientation.Horizontal,
                        OverridesDefaultStyle = true,
                        HorizontalAlignment = HorizontalAlignment.Center,
                        VerticalAlignment = VerticalAlignment.Top,
                    };
                    SeraListe seraListe = new SeraListe
                    {
                        Ad = jObject["Ad"].ToString(),
                        Yol = "C:/Talana/Images/"+jObject["Resim"].ToString(),
                        SeraTarih = jObject["Tarih"].ToString(),
                        SeraSebze = jObject["UrunAdi"].ToString(),
                        SeraID = jObject["Id"].ToString()
                    };
                    seraListe.MouseLeftButtonDown += SeraListe_MouseLeftButtonDown;
                    stackPanel1.Children.Add(seraListe);
                    liste.Children.Add(stackPanel1);
                                                         
                }
            }
            catch (Exception ex) 
            {

            }

        }

        private void SeraListe_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SeraListe seraListe = sender as SeraListe;
            if(seraListe.Yol == "C:/Talana/Images/bosSera.png"){
                UrunDik urunDik = new UrunDik(seraListe.SeraID);
                urunDik.ShowDialog();
                MainWindow.panel.Content = new Seralarim();
            }
            else
                MainWindow.panel.Content = new SeraBilgileri(seraListe.SeraID);
        }
    }
}
