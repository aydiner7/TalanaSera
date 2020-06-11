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
    /// SeraBilgi.xaml etkileşim mantığı
    /// </summary>
    public partial class SeraBilgi : UserControl
    {
        public string Ad { get { return isim.Content.ToString(); } set { isim.Content = value; } }
        public string Ad2 { get { return isim2.Content.ToString(); } set { isim2.Content = value; } }
        public string SeraTarih { get { return tarih.Content.ToString(); } set { tarih.Content = value; } }
        string YolAdres;
        public string Yol
        {
            set
            {
                Uri imageUri = new Uri(value, UriKind.Relative);
                BitmapImage imageBitmap = new BitmapImage(imageUri);
                resim.Source = imageBitmap;
                YolAdres = value;
            }
            get { return YolAdres; }
        }
        public string SeraID { get; set; }
        public string Tur { get; set; }
        
        public SeraBilgi()
        {
            InitializeComponent();
        }


        private void isim_MouseEnter(object sender, MouseEventArgs e)
        {
            isim.Foreground = Brushes.Red;
        }

        private void isim_MouseLeave(object sender, MouseEventArgs e)
        {
            isim.Foreground=Brushes.Navy;
        }

        private void arkarenk_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            SeraBilgileri.panel2.Content = new SeraAyar(Tur,SeraID);
        }
    }
}
