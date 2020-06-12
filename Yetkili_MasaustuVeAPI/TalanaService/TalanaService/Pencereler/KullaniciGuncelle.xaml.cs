using Microsoft.Win32;
using Newtonsoft.Json.Linq;
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
using TalanaService.Models;

namespace TalanaService.Pencereler
{
    /// <summary>
    /// KullaniciGuncelle.xaml etkileşim mantığı
    /// </summary>
    public partial class KullaniciGuncelle : Window
    {
        public List<KullaniciLog> KullaniciVeri { get; set; }
        public KullaniciGuncelle(string id)
        {
            InitializeComponent();
            KullaniciVeri = new List<KullaniciLog>();
            string url = "http://" + App.Current.Properties["Sunucu"].ToString() + ":44444/api/KullaniciBilgi/?id=" + id;

            var client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string gelen = client.DownloadString(url);

            JObject jObject = JObject.Parse(gelen);

            JArray array = JArray.Parse(jObject["liste"].ToString());
            foreach (var item in array)
            {
                KullaniciLog kullaniciLog = new KullaniciLog();
                kullaniciLog.Girilen_Sifre = item["Girilen_Sifre"].ToString();
                kullaniciLog.Kullanici_Sifre = item["Kullanici_Sifre"].ToString();
                kullaniciLog.Platform = item["Platform"].ToString();
                kullaniciLog.Ip = item["Ip"].ToString();
                kullaniciLog.Tarih = item["Tarih"].ToString();
                KullaniciVeri.Add(kullaniciLog);
            }



            JObject kBilgi = JObject.Parse(jObject["kullaniciListe"].ToString());


            string resimyol = kBilgi["Kullanici_Resim"].ToString();
            Kodtxt.Text = resimyol.Substring(0, resimyol.Length - 4);
            Adtxt.Text = kBilgi["Kullanici_Ad"].ToString();
            Sadtxt.Text = kBilgi["Kullanici_Soyad"].ToString();

            kullaniciResim.ImageSource = new BitmapImage(new Uri("c:/Talana/Images/" + resimyol));

            DataContext = this;
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        string bitmapToString()
        {
            byte[] data;
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(resim));
            using (MemoryStream ms = new MemoryStream())
            {
                encoder.Save(ms);
                data = ms.ToArray();
            }
            string temp = "";
            foreach (var s in data)
            {
                temp += "," + s;
            }
            return temp;
        }
        private void KaydetBtn_Click(object sender, RoutedEventArgs e)

        {
            if (!(string.IsNullOrEmpty(Kodtxt.Text) || string.IsNullOrEmpty(Adtxt.Text) || string.IsNullOrEmpty(Sadtxt.Text) || string.IsNullOrEmpty(sifretxt.Password)))
            {
                /*if (resim == null)
                {
                    MessageBox.Show("Resim Seçiniz.");
                    return;
                }
                BitmapEncoder encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(resim));
                File.Delete("c://Talana/Images/" + Kodtxt.Text + ".jpg");
                using (var fileStream = new System.IO.FileStream("c://Talana/Images/" + Kodtxt.Text + ".jpg", System.IO.FileMode.Create))
                {
                    encoder.Save(fileStream);
                }*/

                string url = "http://" + App.Current.Properties["Sunucu"].ToString() + ":44444/api/KullaniciGuncelle/?Ad=" + Adtxt.Text + "&Soyad=" + Sadtxt.Text + "&Sifre=" + sifretxt.Password + "&Kod=" + Kodtxt.Text;

                var client = new WebClient();

                string gelen = client.DownloadString(url);

                if (gelen == "true")
                    MessageBox.Show("Kullanıcı Bilgisi Güncellendi");
                else
                    MessageBox.Show("Kullanıcı Bilgisi Güncelleştirilemedi");

            }
            else
                MessageBox.Show("Boş alan bırakmayınız");
        }
        BitmapImage resim = null;
        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Jpeg files (*.jpg)|*.jpg";
            file.InitialDirectory = @"C:\";
            file.Title = "Lütfen Resim Seçiniz";
            if ((bool)file.ShowDialog())
            {
                resim = new BitmapImage(new Uri(file.FileName));
                kullaniciResim.ImageSource = resim;
            }
        }
    }
}