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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace TalanaSera
{
    /// <summary>
    /// SeraAyar.xaml etkileşim mantığı
    /// </summary>
    public partial class SeraAyar : Page
    {
        DispatcherTimer timer = new DispatcherTimer();
        String sTur, sSeraID;
        public SeraAyar(String Tur , String SeraID)
        {
            InitializeComponent();
            sTur = Tur;
            sSeraID = SeraID;
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.IsEnabled = false;
            timer.Tick += timersay;
            try
            {
                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;
                String url = "http://" + App.Current.Properties["sunucu"].ToString() + ":44444/api/SeraAyar/?Tur=" + Tur + "&SeraID=" + SeraID;
                string gelen = client.DownloadString(url);
                JObject jObject = JObject.Parse(gelen);
                HedefDegerMin.Content = jObject["minAralik"].ToString();
                HedefDegerMax.Content = jObject["maxAralik"].ToString();
                MinAltDeger.Content = jObject["minAralik"].ToString();
                MaxUstDeger.Content = jObject["maxAralik"].ToString();
                SeraCumle1.Content = jObject["cumle1"].ToString();
                SeraCumle2.Content = jObject["cumle2"].ToString();
                slider.Value = Convert.ToInt32(jObject["hedefDeger"].ToString());
                slider1.Value = Convert.ToInt32(jObject["minDeger"].ToString());
                slider2.Value = Convert.ToInt32(jObject["maxDeger"].ToString());
                slider.Minimum = Convert.ToInt32(jObject["minAralik"].ToString());
                slider.Maximum = Convert.ToInt32(jObject["maxAralik"].ToString());
                slider1.Minimum = Convert.ToInt32(jObject["minAralik"].ToString());
                slider1.Maximum = slider2.Value;
                slider2.Maximum = Convert.ToInt32(jObject["maxAralik"].ToString());
                slider2.Minimum = slider1.Value;
                slider1.ValueChanged += Slider1_ValueChanged;
                slider2.ValueChanged += Slider2_ValueChanged;
            }
            catch (Exception ex)
            {
                MinAltDeger.Content = 0;
                MaxUstDeger.Content = 0;
                slider.Value = 0;
                slider1.Value = 0;
                slider2.Value = 0;
                slider.Minimum = 0;
                slider.Maximum = 0;
                slider1.Minimum = 0;
                slider1.Maximum = 0;
                slider2.Maximum = 0;
                slider2.Minimum = 0;
            }
        }

        private void timersay(object sender, EventArgs e)
        {
            sure--;
            zaman.Content = (sure / 60).ToString("00") + ":" + (sure % 60).ToString("00");
            if (sure <= 0)
            {
                sure = 0;
                timer.IsEnabled = false;
                timer.Stop();
                MessageBox.Show("Süre Bitti");

            }
           
           

        }

        private void Slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            slider1.Maximum = slider2.Value;
        }

        private void Slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            slider2.Minimum = slider1.Value;
        }
        int sure = 0;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WebClient webclient = new WebClient();
            webclient.Encoding = Encoding.UTF8;
            String url = "http://" + App.Current.Properties["sunucu"].ToString() + ":44444/api/SeraAyarUpdate/?Tur=" + sTur + "&SeraID=" + sSeraID + "&maxDeger=" + slider2.Value.ToString() + "&minDeger=" + slider1.Value.ToString();
            string gelenDeger = webclient.DownloadString(url);
            if (gelenDeger == "1")
                MessageBox.Show( sTur + "  Aralıkları Güncellendi");
            else
                MessageBox.Show("hata oluştu");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (PresetTimePicker.Text != "Zamanlayıcı")
            {
                string[] dizi = PresetTimePicker.Text.Split(':');
                sure = Convert.ToInt32(dizi[0]) * 60 + Convert.ToInt32(dizi[1]);
                zaman.Content = PresetTimePicker.Text;
                timer.IsEnabled = true;
                timer.Start();
            }
            WebClient webclient = new WebClient();
            webclient.Encoding = Encoding.UTF8;
            String url = "http://" + App.Current.Properties["sunucu"].ToString() + ":44444/api/HedefUpdate/?tur=" + sTur + "&SeraID=" + sSeraID + "&deger="+slider.Value.ToString();
            string gelenDeger = webclient.DownloadString(url);
            if (gelenDeger == "1")
                MessageBox.Show("Hedef " + sTur + " Güncellendi");
            else
                MessageBox.Show("hata oluştu");
        }
    }
}
