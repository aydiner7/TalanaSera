using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// TankEkle.xaml etkileşim mantığı
    /// </summary>
    public partial class TankEkle : Window
    {
        
        public TankEkle()
        {
            InitializeComponent();
            var liste = new ObservableCollection<IlacListe>();
            string url = "http://" + App.Current.Properties["Sunucu"].ToString() + ":44444/api/IlacListe/";

            var client = new WebClient();
            client.Encoding = Encoding.UTF8;

            string gelen = client.DownloadString(url);
            JArray jArray = JArray.Parse(gelen);
            foreach (var item in jArray)
            {
                JObject jObject = JObject.Parse(item.ToString());
                IlacListe ilac = new IlacListe();
                ilac.ID = jObject["ID"].ToString();
                ilac.AD = jObject["AD"].ToString();
                liste.Add(ilac);
            }

            Ilaclar.ItemsSource = liste;
            Ilaclar.DisplayMemberPath = "AD";
            Ilaclar.SelectedValuePath = "ID";
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        
        private void KaydetBtn_Click(object sender, RoutedEventArgs e)

        {
            if (!(string.IsNullOrEmpty(Adtxt.Text) || string.IsNullOrEmpty(Sadtxt.Text) ))
            {
                
                string url = "http://" + App.Current.Properties["Sunucu"].ToString() + ":44444/api/TankEkle/?kapasite=" + Adtxt.Text + "&doluluk=" + Sadtxt.Text+ "&id=" + Ilaclar.SelectedValue;

                var client = new WebClient();

                string gelen = client.DownloadString(url);

                if (gelen == "true")
                    MessageBox.Show("Tank Oluşturuldu");
                else
                    MessageBox.Show("Tank Oluşturulamadı");

            }
            else
                MessageBox.Show("Boş alan bırakmayınız");
        }
        
    }
}
