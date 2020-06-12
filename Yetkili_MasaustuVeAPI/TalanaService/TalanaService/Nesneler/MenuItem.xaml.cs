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

namespace TalanaService.Nesneler
{
    /// <summary>
    /// MenuItem.xaml etkileşim mantığı
    /// </summary>
    public partial class MenuItem : UserControl
    {
       public String SeraID { get; set; } 
       public String yol { set {
                Uri uri = new Uri(value, UriKind.Relative);
                BitmapImage bitmapImage = new BitmapImage(uri);
                menuresim.Source = new BitmapImage(new Uri(value)); } }
        public String isim { get { return menuIsim.Content.ToString(); } set { menuIsim.Content = value; } }

        public Brush arkaplan { get { return border.Background; } set { border.Background = value; } }
        public Boolean secili { get { return durum; } set { durum = value; 
            if(!value)
                border.Background = new SolidColorBrush(Colors.Transparent);
                menuIsim.Foreground = new SolidColorBrush(Colors.Black);
            } }
        private Boolean durum = false;
        public MenuItem()
        {
            InitializeComponent();
        }

        private void border_MouseEnter(object sender, MouseEventArgs e)
        {
            if(!durum)
                border.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void border_MouseLeave(object sender, MouseEventArgs e)
        {
            if (!durum)
                border.Background = new SolidColorBrush(Colors.Transparent);
        }

        private void border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            durum = true;
            border.Background = new SolidColorBrush(Color.FromRgb(156, 39, 176));
            menuIsim.Foreground = new SolidColorBrush(Colors.White);
        }
    }
}
