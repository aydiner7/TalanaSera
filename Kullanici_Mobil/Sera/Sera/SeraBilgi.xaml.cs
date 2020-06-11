using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sera
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SeraBilgi : ContentPage
    {
        StackLayout ortaPanel;
        public SeraBilgi(StackLayout gelenOrta)
        {
            InitializeComponent();
            ortaPanel = gelenOrta;
            try
            {
                string[] geciciresim = { "domates.png", "kivi.png", "bosSera.png" };
                int geciciSay = 0;
                WebClient veriCek = new WebClient();
                String url = "http://192.168.0.10:44444/api/SeraListe/?kod=123";
                string gelen = veriCek.DownloadString(url);
                JArray jArray = JArray.Parse(gelen);
                foreach (var item in jArray)
                {
                    JObject jObject = JObject.Parse(item.ToString());
                    Frame frm = new Frame
                    {
                        BorderColor = Color.FromRgb(220, 232, 66),
                        Margin = new Thickness(45, 10),
                        HeightRequest = 80,
                        CornerRadius = 15,
                        BackgroundColor = Color.FromRgb(96, 99, 79)

                    };

                    frm.GestureRecognizers.Add(new TapGestureRecognizer
                    {
                        Command = new Command(async (t) =>
                        {
                            ortaPanel.Children.Clear();
                            ortaPanel.Children.Add(new SeraIcerik(jObject["Id"].ToString()).Content);
                        })
                    });

                    Grid grd = new Grid
                    {
                        ColumnDefinitions =
                        {
                            new ColumnDefinition { Width = 70 },
                            new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                        }
                    };
                    string resimSource = geciciresim[geciciSay];
                    Image img = new Image
                    {
                        Source = resimSource,
                        Aspect = Aspect.Fill
                    };
                    geciciSay++;
                    Label lbl = new Label
                    {
                        Text = jObject["Ad"].ToString(),
                        VerticalOptions = LayoutOptions.Start,
                        HorizontalOptions = LayoutOptions.Start,
                        Margin = new Thickness(0,10,0,0),
                        TextColor = Color.FromRgb(179, 182, 174),
                        FontSize = 20,
                        FontAttributes = FontAttributes.Bold

                    };
                    Label lbl2 = new Label
                    {
                        Text = jObject["Tarih"].ToString(),
                        VerticalOptions = LayoutOptions.End,
                        HorizontalOptions = LayoutOptions.Start,
                        Margin = new Thickness(110, 0, 0, 0),
                        TextColor = Color.FromRgb(217, 217, 217),
                    };

                    Grid.SetColumn(img, 0);
                    Grid.SetColumn(lbl, 1);
                    Grid.SetColumn(lbl2, 1);
                    grd.Children.Add(img);
                    grd.Children.Add(lbl);
                    grd.Children.Add(lbl2);
                    frm.Content = grd;
                    Liste.Children.Add(frm);
             
                }
            }
            catch (Exception ex)
            {

            }
        }

      

       
    }
}