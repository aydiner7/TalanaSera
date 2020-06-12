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

namespace TalanaService.Pencereler
{
    /// <summary>
    /// KullaniciListe.xaml etkileşim mantığı
    /// </summary>
    public partial class KullaniciListe : Window
    {
        public string KullaniciID { get; set; }
        public bool Durum { get; set; }
        public StackPanel SecilenKullanici { get; set; }

        WebClient client = new WebClient();
        string url = "http://" + App.Current.Properties["Sunucu"].ToString() + ":44444/api/Kullanicilar";
        List<string> KullaniciListesi = new List<string>();
        public KullaniciListe(List<string> KullaniciList)
        {
            InitializeComponent();
            KullaniciListesi = KullaniciList;
            Durum = false;
            kullaniciYukle(KullaniciList);

        }

        public KullaniciListe(bool gelenDeger)
        {
            InitializeComponent();
            Durum = false;
            kullaniciYukle();

        }

        void kullaniciYukle(List<string> KullaniciList)
        {
            client.Encoding = Encoding.UTF8;
            String gelen = client.DownloadString(url);
            JArray jArray = JArray.Parse(gelen);
            int say = 0;
            liste.Children.Clear();
            foreach (var item in jArray)
            {

                JObject jObject = JObject.Parse(item.ToString());
                bool atla = false;
                if(KullaniciList != null)
                {
                    foreach (string list in KullaniciList)
                    {
                        if (list == jObject["Kullanici_ID"].ToString())
                        {
                            atla = true;
                        }
                    }
                }

                if (atla)
                    continue;
                say++;
                StackPanel stackPanel = new StackPanel
                {
                    Margin = new Thickness(0, 0, 0, 0)
                };
                Label IDlabel = new Label { 
                    Visibility = Visibility.Hidden,
                    Content = jObject["Kullanici_ID"]
                };
                stackPanel.Children.Add(IDlabel);
                StackPanel stackPanel2 = new StackPanel
                {
                    Margin = new Thickness(0, 20, 0, 20)
                };

               // if (say % 2 == 0) stackPanel.Background = new SolidColorBrush(Colors.AliceBlue);
                Grid grid = new Grid
                {
                    ColumnDefinitions =
                    {
                        new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                        new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                        new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                        new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                    }

                };
                Rectangle rectangle = new Rectangle
                {
                    Height = 49,
                    Width = 49,
                    RadiusX = 30,
                    RadiusY = 30,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Fill = new ImageBrush
                    {
                        ImageSource = new BitmapImage(new Uri("c:/Talana/Images/" + jObject["Kullanici_Resim"]))
                    }

                };
                grid.Children.Add(rectangle);
                StackPanel kadi = new StackPanel
                {
                    Margin = new Thickness(10, 0, 10, 0)
                };
                Label lbl1 = new Label
                {
                    Content = "Kullanıcı Adı",
                    HorizontalAlignment = HorizontalAlignment.Center
                };
                kadi.Children.Add(lbl1);
                TextBox txt1 = new TextBox
                {
                    Text = jObject["Kullanici_Ad"].ToString(),
                    IsEnabled = false
                };
                kadi.Children.Add(txt1);
                grid.Children.Add(kadi);

                StackPanel ksad = new StackPanel
                {
                    Margin = new Thickness(10, 0, 10, 0)
                };
                Label lbl2 = new Label
                {
                    Content = "Kullanıcı Soyadı",
                    HorizontalAlignment = HorizontalAlignment.Center
                };
                ksad.Children.Add(lbl2);
                TextBox txt2 = new TextBox
                {
                    Text = jObject["Kullanici_Soyad"].ToString(),
                    IsEnabled = false
                };
                ksad.Children.Add(txt2);
                grid.Children.Add(ksad);

                Image image = new Image
                {
                    Width = 30,
                    Source = new BitmapImage(new Uri("c:/Talana/Images/Ekle.png"))
                };
                image.MouseLeftButtonDown += KullaniciSecBTN;
                Grid.SetColumn(rectangle, 0);
                Grid.SetColumn(kadi, 1);
                Grid.SetColumn(ksad, 2);
                Grid.SetColumn(image, 3);
                grid.Children.Add(image);

                stackPanel.Children.Add(stackPanel2);
                stackPanel2.Children.Add(grid);
                liste.Children.Add(stackPanel);





            }
        }



        void kullaniciYukle()
        {
            client.Encoding = Encoding.UTF8;
            String gelen = client.DownloadString(url);
            JArray jArray = JArray.Parse(gelen);
            int say = 0;
            liste.Children.Clear();
            foreach (var item in jArray)
            {

                JObject jObject = JObject.Parse(item.ToString());
               
                say++;
                StackPanel stackPanel = new StackPanel
                {
                    Margin = new Thickness(0, 0, 0, 0)
                };
                Label IDlabel = new Label
                {
                    Visibility = Visibility.Hidden,
                    Content = jObject["Kullanici_ID"]
                };
                stackPanel.Children.Add(IDlabel);
                StackPanel stackPanel2 = new StackPanel
                {
                    Margin = new Thickness(0, 20, 0, 20)
                };

                // if (say % 2 == 0) stackPanel.Background = new SolidColorBrush(Colors.AliceBlue);
                Grid grid = new Grid
                {
                    ColumnDefinitions =
                    {
                        new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                        new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                        new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                        new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                    }

                };
                Rectangle rectangle = new Rectangle
                {
                    Height = 49,
                    Width = 49,
                    RadiusX = 30,
                    RadiusY = 30,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Fill = new ImageBrush
                    {
                        ImageSource = new BitmapImage(new Uri("c:/Talana/Images/" + jObject["Kullanici_Resim"]))
                    }

                };
                grid.Children.Add(rectangle);
                StackPanel kadi = new StackPanel
                {
                    Margin = new Thickness(10, 0, 10, 0)
                };
                Label lbl1 = new Label
                {
                    Content = "Kullanıcı Adı",
                    HorizontalAlignment = HorizontalAlignment.Center
                };
                kadi.Children.Add(lbl1);
                TextBox txt1 = new TextBox
                {
                    Text = jObject["Kullanici_Ad"].ToString(),
                    IsEnabled = false
                };
                kadi.Children.Add(txt1);
                grid.Children.Add(kadi);

                StackPanel ksad = new StackPanel
                {
                    Margin = new Thickness(10, 0, 10, 0)
                };
                Label lbl2 = new Label
                {
                    Content = "Kullanıcı Soyadı",
                    HorizontalAlignment = HorizontalAlignment.Center
                };
                ksad.Children.Add(lbl2);
                TextBox txt2 = new TextBox
                {
                    Text = jObject["Kullanici_Soyad"].ToString(),
                    IsEnabled = false
                };
                ksad.Children.Add(txt2);
                grid.Children.Add(ksad);

                Image image = new Image
                {
                    Width = 30,
                    Source = new BitmapImage(new Uri("c:/Talana/Images/Ekle.png"))
                };
                image.MouseLeftButtonDown += KullaniciSecBTN2;
                Grid.SetColumn(rectangle, 0);
                Grid.SetColumn(kadi, 1);
                Grid.SetColumn(ksad, 2);
                Grid.SetColumn(image, 3);
                grid.Children.Add(image);

                stackPanel.Children.Add(stackPanel2);
                stackPanel2.Children.Add(grid);
                liste.Children.Add(stackPanel);





            }
        }

        private void KullaniciSecBTN(object sender, MouseButtonEventArgs e)
        {
            Image kademe1 = sender as Image;
            Grid kademe2 = kademe1.Parent as Grid;
            StackPanel kademe3 = kademe2.Parent as StackPanel;
            StackPanel kademe4 = kademe3.Parent as StackPanel;
            Label kademe5 = kademe4.Children[0] as Label;
            SecilenKullanici = kademe4;
            KullaniciID = kademe5.Content.ToString();
            Durum = true;
            liste.Children.Clear();
            this.Close();

        }

        private void KullaniciSecBTN2(object sender, MouseButtonEventArgs e)
        {
            Image kademe1 = sender as Image;
            Grid kademe2 = kademe1.Parent as Grid;
            StackPanel kademe3 = kademe2.Parent as StackPanel;
            StackPanel kademe4 = kademe3.Parent as StackPanel;
            Label kademe5 = kademe4.Children[0] as Label;
            
            KullaniciID = kademe5.Content.ToString();

            KullaniciGuncelle kullaniciGuncelle = new KullaniciGuncelle(KullaniciID);
            kullaniciGuncelle.ShowDialog();
            

        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void KullaniciEkleBtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            KullaniciEkle kullaniciEkle = new KullaniciEkle();
            kullaniciEkle.ShowDialog();
            kullaniciYukle();
        }
    }
}
