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
using System.Windows.Shapes;
using TalanaService.Nesneler;
using TalanaService.Pencereler;
using TalanaService.Sayfalar;

namespace TalanaService
{
    /// <summary>
    /// AnaPencere.xaml etkileşim mantığı
    /// </summary>
    public partial class AnaPencere : Window
    {
        public AnaPencere()
        {
            InitializeComponent();
            string url = "http://" + App.Current.Properties["Sunucu"].ToString() + ":44444/api/SeraListe";

            var client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string gelen = client.DownloadString(url);
            JArray jArray = JArray.Parse(gelen);
            foreach (var item in jArray)
            {
                JObject jObject = JObject.Parse(item.ToString());

                Nesneler.MenuItem menu = new Nesneler.MenuItem
                {
                    SeraID = jObject["Id"].ToString(),
                    yol = "c:/Talana/Images/"+jObject["Resim"].ToString(),
                    isim = jObject["Ad"].ToString()
                };
                menu.MouseLeftButtonDown += MenuSecimYapma;
                SeraListesi.Children.Add(menu);
            }
        }

        private void MenuSecimYapma(object sender, MouseButtonEventArgs e)
        {
            Nesneler.MenuItem menu = sender as Nesneler.MenuItem;
            degisenBaslik.Content = menu.isim;
            var sayfa = new SeraBilgi(menu.SeraID);
            degisenPanel.Content = sayfa;
        }

        private void MenuItem_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Nesneler.MenuItem menuItem = (Nesneler.MenuItem)sender;
            degisenBaslik.Content = menuItem.isim;
            var sayfa = new SeraBilgi(menuItem.SeraID);
            degisenPanel.Content = sayfa;
        }

        private void SeraEkle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            degisenBaslik.Content = "Yeni Sera Oluştur";
            var sayfa = new SeraEkle();
            degisenPanel.Content = sayfa;
        }

        private void UserBtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            KullaniciListe kullaniciListe = new KullaniciListe(true);
            kullaniciListe.ShowDialog();
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
