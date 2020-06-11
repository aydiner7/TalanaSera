using Lottie.Forms;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sera
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bildirim : ContentPage
    {
        StackLayout ortaPanel;
        public Bildirim(StackLayout stackLayout)
        {
            InitializeComponent();
            ortaPanel = stackLayout;

            bildirimCek("0", "0");
        }

        void bildirimCek(string ilk, string son)
        {
            try
            {
                string gidecekDeger = "";
                if (ilk != "0" && son != "0")
                    gidecekDeger = "?tarih1=" + ilk + "&tarih2=" + son;

                WebClient wc = new WebClient();
                wc.Encoding = Encoding.UTF8;
                String url = "http://192.168.0.10:44444/api/Bildirim/" + gidecekDeger;
                var gelen = wc.DownloadString(url);
                JArray array = JArray.Parse(gelen);

                erisim.Children.Clear();
                foreach (var item in array)
                {

                    JObject jObject = JObject.Parse(item.ToString());
                    Frame frm = new Frame
                    {
                        BorderColor = Color.FromHex("#cdc9c9"),
                        Margin = new Thickness(0, 10, 0, 0),
                        HeightRequest = 45,
                        CornerRadius = 10,
                        BackgroundColor = Color.FromHex("#eee5de")
                    };
                    Grid grd = new Grid
                    {
                        ColumnDefinitions =
                        {
                            new ColumnDefinition { Width = 70 },
                            new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                            new ColumnDefinition { Width = 90 }
                        }
                    };
                    string resim = "sicak.json";
                    if (jObject["Resim"].ToString() == "isi.png")
                        resim = "sicak.json";
                    if (jObject["Resim"].ToString() == "nem.png")
                        resim = "sulama.json";
                    if (jObject["Resim"].ToString() == "hava.png")
                        resim = "fan.json";
                    if (jObject["Resim"].ToString() == "isik.png")
                        resim = "isik.json";

                    AnimationView animasyon = new AnimationView
                    {
                        Opacity = 1,
                        Animation = resim,
                        AutoPlay = true,
                        Loop = true,
                        VerticalOptions = LayoutOptions.FillAndExpand,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        HeightRequest = 100
                    };
                    Label lbl = new Label
                    {
                        Text = jObject["Sera_Adi"].ToString(),
                        VerticalOptions = LayoutOptions.Start,
                        Margin = new Thickness(0, 0, 0, 15),
                        HorizontalOptions = LayoutOptions.Center,
                        TextColor = Color.FromHex("#36648b"),
                        FontSize = 17,
                        FontAttributes = FontAttributes.Bold
                    };
                    Label lbl2 = new Label
                    {
                        Text = jObject["Olay_Adi"].ToString(),
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.End,
                        Margin = new Thickness(0),
                        TextColor = Color.Red
                    };
                    Label lbl3 = new Label
                    {
                        Text = jObject["Bas_Saat"].ToString() + " → " + jObject["Eski_Olay"].ToString(),
                        HorizontalOptions = LayoutOptions.Start,
                        VerticalOptions = LayoutOptions.Start,
                        Margin = new Thickness(0),
                        TextColor = Color.Red
                    };
                    Label lbl4 = new Label
                    {
                        Text = jObject["Bit_Saat"].ToString() + " → " + jObject["Yeni_Olay"].ToString(),
                        HorizontalOptions = LayoutOptions.Start,
                        VerticalOptions = LayoutOptions.End,
                        Margin = new Thickness(0)
                    };
                    Grid.SetColumn(animasyon, 0);
                    Grid.SetColumn(lbl, 1);
                    Grid.SetColumn(lbl2, 1);
                    Grid.SetColumn(lbl3, 2);
                    Grid.SetColumn(lbl4, 2);
                    grd.Children.Add(animasyon);
                    grd.Children.Add(lbl);
                    grd.Children.Add(lbl2);
                    grd.Children.Add(lbl3);
                    grd.Children.Add(lbl4);
                    frm.Content = grd;
                    erisim.Children.Add(frm);

                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}