using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sera
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Anasayfa : ContentPage
    {
        public static StackLayout orta;
        public Anasayfa()
        {
            InitializeComponent();
            orta = ortaPanel;
            ortaPanel.Children.Clear();
            ortaPanel.Children.Add(new SeraBilgi(ortaPanel).Content);
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            ortaPanel.Children.Clear();
            ortaPanel.Children.Add(new SeraBilgi(ortaPanel).Content);
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            ortaPanel.Children.Clear();
            ortaPanel.Children.Add(new Bildirim(ortaPanel).Content);
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            ortaPanel.Children.Clear();
            ortaPanel.Children.Add(new Profil(ortaPanel).Content);
        }
    }
}