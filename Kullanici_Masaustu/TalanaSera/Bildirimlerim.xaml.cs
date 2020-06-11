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
    /// Bildirimlerim.xaml etkileşim mantığı
    /// </summary>
    public partial class Bildirimlerim : Page
    {
        string[] gunler = { "Pazar", "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi" };

        void bildirimCek(string ilk,string son)
        {
            try
            {
                string gidecekDeger = "";
                if(ilk != "0" && son != "0")
                gidecekDeger = "?tarih1=" + ilk + "&tarih2=" + son;

                WebClient wc = new WebClient();
                wc.Encoding = Encoding.UTF8;
                String url = "http://" + App.Current.Properties["sunucu"].ToString() + ":44444/api/Bildirim/"+gidecekDeger;
                var gelen = wc.DownloadString(url);
                JArray array = JArray.Parse(gelen);
                string geciciTarih = "01.01.1900";
                StackPanel stack = new StackPanel();
                erisim.Children.Clear();
                foreach (var item in array)
                {

                    JObject jObject = JObject.Parse(item.ToString());
                    if (geciciTarih != jObject["Tarih"].ToString())
                    {
                        geciciTarih = jObject["Tarih"].ToString();
                        stack = new StackPanel();
                        erisim.Children.Add(stack);
                        Label label = new Label
                        {
                            Content = jObject["Tarih"],
                            Margin = new Thickness(0, 20, 0, 0),
                            HorizontalAlignment = HorizontalAlignment.Center,
                            Opacity = 0.6,
                            FontWeight = FontWeights.UltraBold
                        };
                        stack.Children.Add(label);
                        StackPanel stack2 = new StackPanel
                        {
                            Height = 2,
                            Background = new SolidColorBrush(Colors.Black),
                            Margin = new Thickness(30, 0, 30, 0),
                            Opacity = 0.3
                        };
                        stack.Children.Add(stack2);
                        string hangiGun = gunler[((int)Convert.ToDateTime(geciciTarih).DayOfWeek)];
                        if (Convert.ToDateTime(geciciTarih).ToShortDateString() == DateTime.Now.ToShortDateString())
                            hangiGun = "Bugün";
                        else if (Convert.ToDateTime(geciciTarih).ToShortDateString() == DateTime.Now.AddDays(-1).ToShortDateString())
                            hangiGun = "Dün";
                        Label label2 = new Label
                        {
                            Content = hangiGun,
                            HorizontalAlignment = HorizontalAlignment.Center,
                            Opacity = 0.6,
                            FontWeight = FontWeights.UltraBold
                        };
                        stack.Children.Add(label2);


                    }
                    BildirimDenetleyicim bildirimDenetleyicim = new BildirimDenetleyicim
                    {
                        Ad = jObject["Sera_Adi"].ToString(),
                        Yol = jObject["Resim"].ToString(),
                        BildirimOzellik = jObject["Olay_Adi"].ToString(),
                        Aralik11 = jObject["Bas_Saat"].ToString() + " → " + jObject["Eski_Olay"].ToString(),
                        Aralik22 = jObject["Bit_Saat"].ToString() + " → " + jObject["Yeni_Olay"].ToString(),
                        Tarih = jObject["Tarih"].ToString()
                    };
                    stack.Children.Add(bildirimDenetleyicim);
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public Bildirimlerim()
        {
            InitializeComponent();
            bildirimCek("0", "0");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DateTime ilkTarih = (DateTime)Secilenilktarih.SelectedDate;
            DateTime sonTarih = (DateTime)Secilensontarih.SelectedDate;
            bildirimCek(ilkTarih.ToShortDateString(), sonTarih.ToShortDateString());
        }
    }
}
