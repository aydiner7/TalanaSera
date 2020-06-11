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

namespace TalanaSera
{
    /// <summary>
    /// SunucuBilgi.xaml etkileşim mantığı
    /// </summary>
    public partial class SunucuBilgi : Window
    {
        public SunucuBilgi()
        {
            InitializeComponent();

            string dosya_yolu = @"C:\Talana\config.txt";
            if (File.Exists(dosya_yolu))
            {
                List<string> dosya = ds.dosyadanOku();
                if(dosya.Count == 4)
                {
                    sAdi.Text = dosya[0];
                    kAdi.Text = dosya[1];
                    kSifre.Password = dosya[2];
                    kKodu.Text = dosya[3];
                }
            }   
           
        }
        Dosya ds = new Dosya();
        private void kaydet_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.Properties.Contains("sunucu"))
                Application.Current.Properties["sunucu"] = sAdi.Text;
            else
                Application.Current.Properties.Add("sunucu", sAdi.Text);

            if (Application.Current.Properties.Contains("kullaniciAdi"))
                Application.Current.Properties["kullaniciAdi"] = kAdi.Text;
            else
                Application.Current.Properties.Add("kullaniciAdi", kAdi.Text);

            if (Application.Current.Properties.Contains("kullaniciSifre"))
                Application.Current.Properties["kullaniciSifre"] = kSifre.Password;
            else
                Application.Current.Properties.Add("kullaniciSifre", kSifre.Password);

            if (Application.Current.Properties.Contains("kullaniciKodu"))
                Application.Current.Properties["kullaniciKodu"] = kKodu.Text;
            else
                Application.Current.Properties.Add("kullaniciKodu", kKodu.Text);
            ds.dosyayaYaz(sAdi.Text, kAdi.Text, kSifre.Password, kKodu.Text);
        }

        private void test_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                WebClient veriCek = new WebClient();
                String url = "http://" + App.Current.Properties["sunucu"].ToString() + ":44444/api/Baglanti/?Kadi=" + App.Current.Properties["kullaniciAdi"].ToString() + "&Sifre=" + App.Current.Properties["kullaniciSifre"].ToString();
                string gelen = veriCek.DownloadString(url);
                if (gelen == "true")
                {
                    MessageBox.Show("Bağlantı Sağlandı");
                    WebClient kBilgi = new WebClient();
                    url = "http://" + App.Current.Properties["sunucu"].ToString() + ":44444/api/KullaniciKontrol/?Kod=" + App.Current.Properties["kullaniciKodu"].ToString();
                    gelen = kBilgi.DownloadString(url);
                    if(gelen == "null")
                    {
                        MessageBox.Show("Kullanıcı Kodu Hatalı");
                    }
                    else
                    {
                        gelen = gelen.Substring(1, gelen.Length - 2);
                        if (Application.Current.Properties.Contains("kullaniciResim"))
                            Application.Current.Properties["kullaniciResim"] = gelen;
                        else
                            Application.Current.Properties.Add("kullaniciResim", gelen);
                    }
                }
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
