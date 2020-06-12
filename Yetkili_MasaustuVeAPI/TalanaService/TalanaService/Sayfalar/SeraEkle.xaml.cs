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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TalanaService.Pencereler;

namespace TalanaService.Sayfalar
{
    /// <summary>
    /// SeraEkle.xaml etkileşim mantığı
    /// </summary>
    public partial class SeraEkle : Page
    {
        
        public SeraEkle()
        {
            InitializeComponent();
        }
        int menuAdet = 5; // not : indis hareketleri için sistem 0 dan başlıyarak hesaplanmaktadır.
        int aktifSira = 0;
        private void SiraIleri_Click(object sender, RoutedEventArgs e)
        {
            if(aktifSira == 0)
            {
                if (string.IsNullOrEmpty(txtSeraAdi.Text) || SecilenKullanicilar.Children.Count == 0)
                {
                    MessageBox.Show("Bilgileri Eksiksiz Doldurun");
                    return;
                }
            }
            else if (aktifSira == 1)
            {
                StackPanel kademe1 = DisOrtamSensorleri.Children[0] as StackPanel;
                Grid kademe2 = kademe1.Children[0] as Grid;
                StackPanel kademe3 = kademe2.Children[0] as StackPanel;
                TextBox kademe4 = kademe3.Children[1] as TextBox;
                if (string.IsNullOrEmpty(kademe4.Text))
                {
                    MessageBox.Show("Bilgileri Eksiksiz Doldurun");
                    return;
                }
            }

            SiraGeri.IsEnabled = true;
            aktifSira++;
            Border border = (Border)SeraEkleSiraBaslik.Children[aktifSira];
            border.Background = new SolidColorBrush(Colors.ForestGreen);
            Grid grid = (Grid)SeraEkleSiraIcerik.Children[aktifSira - 1];
            grid.Visibility = Visibility.Hidden;
            Grid grid2 = (Grid)SeraEkleSiraIcerik.Children[aktifSira];
            grid2.Visibility = Visibility.Visible;
            if (aktifSira >= menuAdet)
            {
                aktifSira = menuAdet;
                SiraIleri.IsEnabled = false;
            }
        }

        private void SiraGeri_Click(object sender, RoutedEventArgs e)
        {
            SiraIleri.IsEnabled = true;
            aktifSira--;
            Border border = (Border)SeraEkleSiraBaslik.Children[aktifSira+1];
            border.Background = new SolidColorBrush(Colors.Transparent);
            Grid grid = (Grid)SeraEkleSiraIcerik.Children[aktifSira + 1];
            grid.Visibility = Visibility.Hidden;
            Grid grid2 = (Grid)SeraEkleSiraIcerik.Children[aktifSira];
            grid2.Visibility = Visibility.Visible;
            if (aktifSira <= 0)
            {
                aktifSira = 0;
                SiraGeri.IsEnabled = false;
            }
        }

        private void SeraKaydet_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            string url = "http://" + App.Current.Properties["Sunucu"].ToString() + ":44444/api/SeraEkle/?SeraAdi="+txtSeraAdi.Text+"&DisOrtamAdi="+txtdisOrtamAdi.Text+"&kID="+SecilenKullaniciID+"&IlactankID="+IlacTankID+"&SuMotorAdi="+txtsumotoradi.Text+"&IlacMotorAdi="+txtIlacMotorAdi.Text+"&IsikSiddetAdi="+txtisiksiddetadi.Text+"&IsikKaynakAdi="+txtisikkaynakadi.Text+"&tnsAdi="+tnsAdi.Text+"&hnsAdi="+hnsAdi.Text+"&hksAdi="+hksAdi.Text+"&fanAdi="+fanAdi.Text;
            client.Encoding = Encoding.UTF8;
            string gelen = client.DownloadString(url);

            if (gelen == "true")
                MessageBox.Show("Yeni Sera Düzeniniz Oluşturuldu");
            else
                MessageBox.Show("Sera Düzeni oluşturulamadı");
        }
        List<string> KullaniciList = new List<string>();

        string SecilenKullaniciID = "";
        private void KullaniciSecBtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            KullaniciListe kullaniciListe = new KullaniciListe(KullaniciList);
            kullaniciListe.ShowDialog();
            if(kullaniciListe.Durum)
            {
                KullaniciList.Add(kullaniciListe.KullaniciID);
                StackPanel kademe1 = kullaniciListe.SecilenKullanici;
                StackPanel kademe2 = kademe1.Children[1] as StackPanel;
                Grid kademe3 = kademe2.Children[0] as Grid;
                Image kademe4 = kademe3.Children[3] as Image;
                kademe4.MouseLeftButtonDown += KullaniciSecmeIptal;
                kademe4.Source = new BitmapImage(new Uri("c:/Talana/Images/Sil.png"));
                SecilenKullaniciID = kullaniciListe.KullaniciID;
                SecilenKullanicilar.Children.Add(kademe1);
            }
        }

        private void KullaniciSecmeIptal(object sender, MouseButtonEventArgs e)
        {
            Image kademe1 = sender as Image;
            Grid kademe2 = kademe1.Parent as Grid;
            StackPanel kademe3 = kademe2.Parent as StackPanel;
            StackPanel kademe4 = kademe3.Parent as StackPanel;
            Label kademe5 = kademe4.Children[0] as Label;
            KullaniciList.Remove(kademe5.Content.ToString());
            SecilenKullanicilar.Children.Remove(kademe4);
        }

        private void DisOrtamEkleBtn(object sender, MouseButtonEventArgs e)
        {
            Image resim = sender as Image;
            resim.Source = new BitmapImage(new Uri("c:/Talana/Images/Sil.png"));
            resim.MouseLeftButtonDown -= DisOrtamEkleBtn;
            resim.MouseLeftButtonDown += DisOrtamSilBtn;
            StackPanel stackPanel = new StackPanel
            {
                Margin = new Thickness(0,0,0,15)
            };
            Grid grid = new Grid { 
                ColumnDefinitions = {
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)}
                }
            };
            stackPanel.Children.Add(grid);
            StackPanel stack = new StackPanel
            {
                Margin = new Thickness(10, 0, 10, 0)
            };
            Grid.SetColumn(stack, 0);
            grid.Children.Add(stack);
            Label lbl1 = new Label
            {
                Content = "Dış Ortam Adı",
                HorizontalAlignment = HorizontalAlignment.Center
            };
            stack.Children.Add(lbl1);
            TextBox txt1 = new TextBox();
            stack.Children.Add(txt1);
            Image image = new Image
            {
                Width = 30,
                Source = new BitmapImage(new Uri("c:/Talana/Images/Ekle.png"))
            };
            image.MouseLeftButtonDown += DisOrtamEkleBtn;
            Grid.SetColumn(image, 3);
            grid.Children.Add(image);
            DisOrtamSensorleri.Children.Add(stackPanel);





                                             



        }

        private void DisOrtamSilBtn(object sender, MouseButtonEventArgs e)
        {
            Image kademe1 = sender as Image;
            Grid kademe2 = kademe1.Parent as Grid;
            StackPanel kademe3 = kademe2.Parent as StackPanel;
            DisOrtamSensorleri.Children.Remove(kademe3);
        }
        string IlacTankID = "";
        private void ilacListeBtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TankListe kullaniciListe = new TankListe(KullaniciList);
            kullaniciListe.ShowDialog();
            if (kullaniciListe.Durum)
            {
                ilacTankBilgi.Maximum = kullaniciListe.sprog.Maximum;
                ilacTankBilgi.Value = kullaniciListe.sprog.Value;
                ilacAdi.Text = kullaniciListe.slbl.Text;
                IlacTankID = kullaniciListe.KullaniciID;
            }
        }
    }
}
