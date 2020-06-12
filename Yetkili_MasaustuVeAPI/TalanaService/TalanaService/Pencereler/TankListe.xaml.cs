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
    /// TankListe.xaml etkileşim mantığı
    /// </summary>
    public partial class TankListe : Window
    {
        public string KullaniciID { get; set; }
        public TextBox slbl { get; set; }
        public ProgressBar sprog { get; set; }
        public bool Durum { get; set; }
        public StackPanel SecilenKullanici { get; set; }

        WebClient client = new WebClient();
        string url = "http://" + App.Current.Properties["Sunucu"].ToString() + ":44444/api/IlacTankListele";
        List<string> KullaniciListesi = new List<string>();
        public TankListe(List<string> KullaniciList)
        {
            InitializeComponent();
           
            Durum = false;
            kullaniciYukle();

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
                

                // if (say % 2 == 0) stackPanel.Background = new SolidColorBrush(Colors.AliceBlue);
                Grid grid = new Grid
                {
                    ColumnDefinitions =
                    {
                        new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                        new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                        new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                    }

                };
               
                StackPanel kadi = new StackPanel
                {
                    Margin = new Thickness(10, 0, 10, 0)
                };
                Label lbl1 = new Label
                {
                    Content = "İlaç Adı",
                    HorizontalAlignment = HorizontalAlignment.Center
                };
                kadi.Children.Add(lbl1);
                TextBox txt1 = new TextBox
                {
                    Text = jObject["IlacAdi"].ToString(),
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
                    Content = "Tank Durumu",
                    HorizontalAlignment = HorizontalAlignment.Center
                };
                ksad.Children.Add(lbl2);
                ProgressBar txt2 = new ProgressBar
                {
                    IsEnabled = false,
                    Maximum = Convert.ToInt32(jObject["Kapasite"].ToString()),
                    Value = Convert.ToInt32(jObject["Doluluk"].ToString())
                };
                ksad.Children.Add(txt2);
                grid.Children.Add(ksad);

                StackPanel st1 = new StackPanel();
                Label lblg = new Label
                {
                    Visibility = Visibility.Hidden,
                    Content = jObject["ID"].ToString()
                };
                Image image = new Image
                {
                    Width = 30,
                    Source = new BitmapImage(new Uri("c:/Talana/Images/Ekle.png"))
                };
                st1.Children.Add(lblg);
                st1.Children.Add(image);

                image.MouseLeftButtonDown += KullaniciSecBTN;
                Grid.SetColumn(kadi, 0);
                Grid.SetColumn(ksad, 1);
                Grid.SetColumn(st1, 2);
                grid.Children.Add(st1);

                liste.Children.Add(grid);





            }
        }

        private void KullaniciSecBTN(object sender, MouseButtonEventArgs e)
        {
            Image kademe = sender as Image;
            StackPanel kademe1 = kademe.Parent as StackPanel;
            Grid kademe2 = kademe1.Parent as Grid;
            StackPanel kademe3 = kademe2.Children[0] as StackPanel;
            StackPanel kademe4 = kademe2.Children[1] as StackPanel;
            Label kademe5 = kademe1.Children[0] as Label;
            KullaniciID = kademe5.Content.ToString();
            Durum = true;
            slbl = kademe3.Children[1] as TextBox;
            sprog = kademe4.Children[1] as ProgressBar;
            liste.Children.Clear();
            this.Close();

        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void KullaniciEkleBtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TankEkle tankEkle = new TankEkle();
            tankEkle.ShowDialog();
            kullaniciYukle();
        }
    }
}

