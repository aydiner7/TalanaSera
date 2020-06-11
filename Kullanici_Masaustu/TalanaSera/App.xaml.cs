using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows;

namespace TalanaSera
{
    /// <summary>
    /// App.xaml etkileşim mantığı
    /// </summary>
    public partial class App : Application
    {
        Dosya ds = new Dosya();
        public App()
        {
            string dosya_yolu = @"C:\Talana\config.txt";
            if (File.Exists(dosya_yolu))
            {
                List<string> dosya = ds.dosyadanOku();
                if (dosya.Count == 4)
                {
                    if (Application.Current.Properties.Contains("sunucu"))
                        Application.Current.Properties["sunucu"] = dosya[0];
                    else
                        Application.Current.Properties.Add("sunucu", dosya[0]);

                    if (Application.Current.Properties.Contains("kullaniciAdi"))
                        Application.Current.Properties["kullaniciAdi"] = dosya[1];
                    else
                        Application.Current.Properties.Add("kullaniciAdi", dosya[1]);

                    if (Application.Current.Properties.Contains("kullaniciSifre"))
                        Application.Current.Properties["kullaniciSifre"] = dosya[2];
                    else
                        Application.Current.Properties.Add("kullaniciSifre", dosya[2]);

                    if (Application.Current.Properties.Contains("kullaniciKodu"))
                        Application.Current.Properties["kullaniciKodu"] = dosya[3];
                    else
                        Application.Current.Properties.Add("kullaniciKodu", dosya[3]);
                }
            }

            try
            {
                WebClient veriCek = new WebClient();
                String url = "http://" + App.Current.Properties["sunucu"].ToString() + ":44444/api/Baglanti/?Kadi=" + App.Current.Properties["kullaniciAdi"].ToString() + "&Sifre=" + App.Current.Properties["kullaniciSifre"].ToString();
                string gelen = veriCek.DownloadString(url);
                if (gelen == "true")
                {
                    WebClient kBilgi = new WebClient();
                    url = "http://" + App.Current.Properties["sunucu"].ToString() + ":44444/api/KullaniciKontrol/?Kod=" + App.Current.Properties["kullaniciKodu"].ToString();
                    gelen = kBilgi.DownloadString(url);
                    if (gelen == "null")
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
