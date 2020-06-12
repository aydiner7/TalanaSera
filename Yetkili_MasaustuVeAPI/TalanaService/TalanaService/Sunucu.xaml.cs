using System;
using System.Collections.Generic;
using System.IO;
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
using TalanaService.Fonksiyonlar;

namespace TalanaService
{
    /// <summary>
    /// Sunucu.xaml etkileşim mantığı
    /// </summary>
    public partial class Sunucu : Window
    {
        Dosya dosya = new Dosya();
        public Sunucu()
        {
            InitializeComponent();
            string dosya_yolu = @"C:\Talana\config.txt";
            if (File.Exists(dosya_yolu))
            {

                List<string> sunucuVeri = dosya.dosyadanOku();
                Sunucutxt.Text = sunucuVeri[0];
                Kaditxt.Text = sunucuVeri[1];
                sifretxt.Password = sunucuVeri[2];
            }
        }


        private void KaydetBtn_Click(object sender, RoutedEventArgs e)
        {
            if (App.Current.Properties.Contains("Sunucu"))
                App.Current.Properties["Sunucu"] = Sunucutxt.Text;
            else
                App.Current.Properties.Add("Sunucu", Sunucutxt.Text);
            if (App.Current.Properties.Contains("Kadi"))
                App.Current.Properties["Kadi"] = Kaditxt.Text;
            else
                App.Current.Properties.Add("Kadi", Kaditxt.Text);
            if (App.Current.Properties.Contains("Sifre"))
                App.Current.Properties["Sifre"] = sifretxt.Password;
            else
                App.Current.Properties.Add("Sifre", sifretxt.Password);

            dosya.dosyayaYaz(Sunucutxt.Text, Kaditxt.Text, sifretxt.Password);
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void TestBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                WebClient veriCek = new WebClient();
                String url = "http://"+App.Current.Properties["Sunucu"].ToString()+":44444/api/Baglanti/?Kadi="+ App.Current.Properties["Kadi"].ToString()+"&Sifre="+ App.Current.Properties["Sifre"].ToString();
                string gelen = veriCek.DownloadString(url);
                if (gelen == "true")
                    MessageBox.Show("Bağlantı Sağlandı");
                else
                    MessageBox.Show("Bağlantı Başarısız");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sunucuya Bağlanılamadı.\nHata :" + ex.Message);
            }
        }
    }
}
