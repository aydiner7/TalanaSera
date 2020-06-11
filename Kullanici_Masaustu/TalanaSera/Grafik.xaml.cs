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

namespace TalanaSera
{
    /// <summary>
    /// Grafik.xaml etkileşim mantığı
    /// </summary>
    public partial class Grafik : Page
    {
        public Grafik()
        {
            InitializeComponent();

            try
            {
                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;
                String url = "http://" + App.Current.Properties["sunucu"].ToString() + ":44444/api/AnalizGrafik/";
                var gelen = client.DownloadString(url);
                JArray jArray = JArray.Parse(gelen);
                foreach (var item in jArray)
                {
                    JObject jObject = JObject.Parse(item.ToString());
                    Grid grid = new Grid
                    {
                        Margin = new Thickness(30)
                    };
                    ProgressBar progressBar = new ProgressBar
                    {
                        Width = 200,
                        Maximum = 365,
                        Value = Convert.ToInt32(jObject["Kalan"].ToString()),
                        Foreground = new SolidColorBrush(Colors.Yellow),
                        VerticalAlignment = VerticalAlignment.Top,
                        HorizontalAlignment = HorizontalAlignment.Center,
                        //Style = MaterialDesignThemes.Wpf.RatingBar
                        //Style=(Style)Resources["MaterialDesignCircularProgressBar"]
                        Style=(Style)Application.Current.Resources["MaterialDesignCircularProgressBar"]
                    };
                    StackPanel stack = new StackPanel
                    {
                        Background = new SolidColorBrush(Colors.White),
                        HorizontalAlignment = HorizontalAlignment.Center,
                        Margin = new Thickness(0, 0, -260, 0),
                        Opacity = 0.1,
                        Height = 100,
                        Width = 1
                    };
                    TextBlock block1 = new TextBlock
                    {
                        HorizontalAlignment = HorizontalAlignment.Center,
                        VerticalAlignment = VerticalAlignment.Center,
                        Foreground = new SolidColorBrush(Colors.Yellow),
                        Text = jObject["Kalan"].ToString(),
                        FontSize = 40

                    };
                    TextBlock block2 = new TextBlock
                    {
                        HorizontalAlignment = HorizontalAlignment.Center,
                        VerticalAlignment = VerticalAlignment.Bottom,
                        Foreground = new SolidColorBrush(Colors.AliceBlue),
                        Text = jObject["Sera_Ad"].ToString(),
                        FontSize = 20,
                        Opacity = 0.4,
                        Margin = new Thickness(0, 0, 0, -50)

                    };
                    grid.Children.Add(progressBar);
                    grid.Children.Add(stack);
                    grid.Children.Add(block1);
                    grid.Children.Add(block2);
                    GrafikListe.Children.Add(grid);
                }

            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
