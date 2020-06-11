using System;
using System.Collections.Generic;
using System.Linq;
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
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Frame panel;

        public MainWindow()
        {
            InitializeComponent();
            panel = ortaPanel;

            ortaPanel.Content = new Seralarim();
        }

        private void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
        }

        void MenuSifirla(object gelen)
        {
            MenuItem menuItem = (MenuItem)gelen;
            menuItem.arkaplan = new SolidColorBrush(Colors.Transparent);
        }
        private void menu1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MenuSifirla(menular.Children[1]);
            MenuSifirla(menular.Children[3]);
            MenuSifirla(menular.Children[5]);
            MenuSifirla(menular.Children[7]);
            MenuItem menuItem = (MenuItem)sender;
            menuItem.arkaplan = new SolidColorBrush(Colors.IndianRed);


        }

        private void bildirim_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void Seralarim_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void hesabim_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void bildirim_MouseEnter(object sender, MouseEventArgs e)
        {
            bildirim.Background = Brushes.IndianRed;
        }

        private void bildirim_MouseLeave(object sender, MouseEventArgs e)
        {
            bildirim.Background = Brushes.Transparent;

        }

        private void Seralarim_MouseEnter(object sender, MouseEventArgs e)
        {
            Seralarim.Background = Brushes.IndianRed;
        }

        private void Seralarim_MouseLeave(object sender, MouseEventArgs e)
        {
            Seralarim.Background = Brushes.Transparent;
        }

        private void hesabim_MouseEnter(object sender, MouseEventArgs e)
        {
            hesabim.Background = Brushes.IndianRed;

        }

        private void hesabim_MouseLeave(object sender, MouseEventArgs e)
        {
            hesabim.Background = Brushes.Transparent;
        }

        private void Seralarim_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MenuSifirla(menular.Children[1]);
            MenuSifirla(menular.Children[3]);
            MenuSifirla(menular.Children[5]);
            MenuSifirla(menular.Children[7]);
            MenuItem menuItem = (MenuItem)sender;
            menuItem.arkaplan = new SolidColorBrush(Colors.IndianRed);
            ortaPanel.Content = new Seralarim();
        }

        private void bildirim_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MenuSifirla(menular.Children[1]);
            MenuSifirla(menular.Children[3]);
            MenuSifirla(menular.Children[5]);
            MenuSifirla(menular.Children[7]);
            MenuItem menuItem = (MenuItem)sender;
            menuItem.arkaplan = new SolidColorBrush(Colors.IndianRed);

             ortaPanel.Content = new Bildirimlerim();
        }

        private void hesabim_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MenuSifirla(menular.Children[1]);
            MenuSifirla(menular.Children[3]);
            MenuSifirla(menular.Children[5]);
            MenuSifirla(menular.Children[7]);
            MenuItem menuItem = (MenuItem)sender;
            menuItem.arkaplan = new SolidColorBrush(Colors.IndianRed);
            ortaPanel.Content = new profil();

        }

        private void profilim_MouseEnter(object sender, MouseEventArgs e)
        {
           /* profilim.Background = Brushes.IndianRed;
            kirmiziCizgi.Background = Brushes.Black;
            cizgi.Background = Brushes.White; */

        }

        private void profilim_MouseLeave(object sender, MouseEventArgs e)
        {
            /*
            profilim.Background = Brushes.Black;
            kirmiziCizgi.Background = Brushes.Red;
            cizgi.Background = Brushes.White;  */
        }

        private void grafik_MouseEnter(object sender, MouseEventArgs e)
        {
            grafik.Background = Brushes.IndianRed;
        }

        private void grafik_MouseLeave(object sender, MouseEventArgs e)
        {
            grafik.Background = Brushes.Transparent;
        }

        private void grafik_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MenuSifirla(menular.Children[1]);
            MenuSifirla(menular.Children[3]);
            MenuSifirla(menular.Children[5]);
            MenuSifirla(menular.Children[7]);
            MenuItem menuItem = (MenuItem)sender;
            menuItem.arkaplan = new SolidColorBrush(Colors.IndianRed);
            ortaPanel.Content = new Grafik();

        }
    }
}
