using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using TalanaSera.Models.dto;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TalanaSera
{
    /// <summary>
    /// login.xaml etkileşim mantığı
    /// </summary>
    public partial class login : Window
    {
        string gecici;
        public login()
        {
            InitializeComponent();
        }

        private async void giris_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                WebClient veriCek = new WebClient();
                String url = "http://" + Application.Current.Properties["sunucu"].ToString() + ":44444/api/Baglanti/?Kadi=" + Application.Current.Properties["kullaniciAdi"].ToString() + "&Sifre=" + Application.Current.Properties["kullaniciSifre"].ToString();
                string gelen = veriCek.DownloadString(url);
                if (gelen == "true")
                {
                    if (kullanicidogrula(Application.Current.Properties["kullaniciKodu"].ToString(), sifre.Password))
                    {

                        MainWindow sayfa = new MainWindow();
                        this.Hide();
                        sayfa.Show();

                    }
                    else
                    {
                        MessageBox.Show("Şifre Hatalı");
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
        Kullanici kullanici;
        private bool kullanicidogrula(string kod,string sifre)
        {
            try
            {
                WebClient webClient = new WebClient();
                string gelen = webClient.DownloadString("http://" + Application.Current.Properties["sunucu"].ToString()+ ":44444/api/KullaniciGiris/?kod="+kod+"&sifre="+sifre);
                JObject jObject1 = JObject.Parse(gelen);
                return true;
            }
            catch (Exception ex)
            {

                string hata = ex.Message;
                return false;
            }

        }
        private void git_Click(object sender, RoutedEventArgs e)
        {
            SunucuBilgi sb = new SunucuBilgi();
            sb.ShowDialog();
            if (Application.Current.Properties.Contains("kullaniciResim"))
            {
                string url = "C:/Talana/Images/" + Application.Current.Properties["kullaniciResim"].ToString();
                profilResim.Source = new BitmapImage(new Uri(url, UriKind.Absolute));
            }
        }


        private void cek_Checked(object sender, RoutedEventArgs e)
        {
            
             if (cek.IsChecked==true)
            {
                gecici = sifre.Password.ToString();
                gizlisifre.Content = gecici;
                gizlisifre.Visibility = Visibility.Visible;
            }
            else if(cek.IsChecked==false)
            {
                gecici = "";
                gizlisifre.Content = gecici;

            }

        }


    }
}
