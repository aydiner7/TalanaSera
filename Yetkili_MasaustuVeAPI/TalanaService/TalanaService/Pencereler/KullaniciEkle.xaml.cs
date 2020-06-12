using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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
using Newtonsoft.Json;
using System.Net.Http.Headers;
using Microsoft.Win32;
using System.Net;

namespace TalanaService.Pencereler
{
    /// <summary>
    /// KullaniciEkle.xaml etkileşim mantığı
    /// </summary>
    public partial class KullaniciEkle : Window
    {
        public KullaniciEkle()
        {
            InitializeComponent();
            Random random = new Random();
            int ilksayi = random.Next(1000, 9999);
            int ikisayi = random.Next(1000, 9999);
            int ucsayi = random.Next(1000, 9999);
            Kodtxt.Text = ilksayi + "" + ikisayi + "" + ucsayi;
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
            foreach(var s in data)
            {
                temp += "," + s;
            }
            return temp;
        }
        private void KaydetBtn_Click(object sender, RoutedEventArgs e)
        
        {
            if (!(string.IsNullOrEmpty(Kodtxt.Text) || string.IsNullOrEmpty(Adtxt.Text) || string.IsNullOrEmpty(Sadtxt.Text) || string.IsNullOrEmpty(sifretxt.Password)))
            {
                if(resim == null)
                {
                    MessageBox.Show("Resim Seçiniz.");
                    return;
                }
                BitmapEncoder encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(resim));

                using (var fileStream = new System.IO.FileStream("c://Talana/Images/"+Kodtxt.Text+".jpg", System.IO.FileMode.Create))
                {
                    encoder.Save(fileStream);
                }

                string url = "http://" + App.Current.Properties["Sunucu"].ToString() + ":44444/api/KullaniciEkle/?Ad="+Adtxt.Text+"&Soyad="+Sadtxt.Text+"&Sifre="+sifretxt.Password+"&Kod="+Kodtxt.Text;

                var client = new WebClient();

                string gelen = client.DownloadString(url);

                if (gelen == "true")
                    MessageBox.Show("Kullanıcı Oluşturuldu");
                else
                    MessageBox.Show("Kullanıcı Oluşturulamadı");

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
