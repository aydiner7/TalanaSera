using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
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
using TalanaService.Fonksiyonlar;

namespace TalanaService
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
   
    public partial class MainWindow : Window
    {
        Dosya dosya = new Dosya();
        public MainWindow()
        {
            InitializeComponent();
            string dosya_yolu = @"C:\Talana\config.txt";
            if (File.Exists(dosya_yolu))
            {

                List<string> sunucuVeri = dosya.dosyadanOku();

                if (App.Current.Properties.Contains("Sunucu"))
                    App.Current.Properties["Sunucu"] = sunucuVeri[0];
                else
                    App.Current.Properties.Add("Sunucu", sunucuVeri[0]);
                if (App.Current.Properties.Contains("Kadi"))
                    App.Current.Properties["Kadi"] = sunucuVeri[1];
                else
                    App.Current.Properties.Add("Kadi", sunucuVeri[1]);
                if (App.Current.Properties.Contains("Sifre"))
                    App.Current.Properties["Sifre"] = sunucuVeri[2];
                else
                    App.Current.Properties.Add("Sifre", sunucuVeri[2]);
                
            }
        }

        private void AppKapat_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

       // veritabaniDataContext db = new veritabaniDataContext();

        private bool kullanicidogrula(string kAdi, string kParola)
        {
          
            if (kAdi == "Admin" && kParola == "Admin")
            {
                return true;
            }

            else
            {
                return false;
            }

        }


        private void GirisBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                WebClient veriCek = new WebClient();
                String url = "http://" + App.Current.Properties["Sunucu"].ToString() + ":44444/api/Baglanti/?Kadi=" + App.Current.Properties["Kadi"].ToString() + "&Sifre=" + App.Current.Properties["Sifre"].ToString();
                string gelen = veriCek.DownloadString(url);
                if (gelen == "true")
                {
                    if (kullanicidogrula(tctxt.Text, sifretxt.Password))
                    {

                        AnaPencere sayfa = new AnaPencere();
                        this.Hide();
                        sayfa.Show();

                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı / Şifre Hatalı");
                    }
                }
                else
                    MessageBox.Show("Sunucu Ayarlarınızı Kontrol Ediniz");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sunucuya Bağlanılamadı.\nHata :" + ex.Message);
            }
            
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Sunucu sunucu = new Sunucu();
            sunucu.ShowDialog();
        }
    }
}

