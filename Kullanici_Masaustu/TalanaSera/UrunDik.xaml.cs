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
using TalanaSera.Models.dto;

namespace TalanaSera
{
    /// <summary>
    /// UrunDik.xaml etkileşim mantığı
    /// </summary>
    public partial class UrunDik : Window
    {
        public string ID;
        public UrunDik(string SeraID)
        {
            InitializeComponent();
            ID = SeraID;
            WebClient client = new WebClient();
            String url = "http://" + App.Current.Properties["sunucu"].ToString() + ":44444/api/UrunListe/";
            string gelen = client.DownloadString(url);
            JArray jArray = JArray.Parse(gelen);
            List<Urunler> UrunData = new List<Urunler>();
            foreach (var item in jArray)
            {
                JObject jObject = JObject.Parse(item.ToString());
                Urunler urunler = new Urunler(jObject["Id"].ToString(), jObject["Ad"].ToString());
                UrunData.Add(urunler);
            }
            UrunListesi.ItemsSource = UrunData;
            UrunListesi.DisplayMemberPath = "Ad";
            UrunListesi.SelectedValuePath = "Id";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(UrunListesi.SelectedValue != null)
            {
                WebClient client = new WebClient();
                String url = "http://" + App.Current.Properties["sunucu"].ToString() + ":44444/api/UrunDik/?SeraID="+ID+"&UrunID="+ UrunListesi.SelectedValue.ToString();
                string gelen = client.DownloadString(url);
                if(gelen == "1")
                {
                    MessageBox.Show("Sera Aktifleşti.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tekrar Deneyiniz");
                }
            }
        }
    }
}
