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
    /// SeraListe.xaml etkileşim mantığı
    /// </summary>
    public partial class SeraListe : UserControl
    {
        public string SeraID { get; set; }
        public string Ad { get { return isim.Content.ToString(); } set { isim.Content = value; } }
        public string SeraTarih { get { return tarih.Content.ToString(); } set { tarih.Content = value; } }
        public string SeraSebze { get { return sebze.Content.ToString(); } set { sebze.Content = value; } }

        string yolAdres;

        public string Yol
        {
            set
            {
                Uri imageUri = new Uri(value, UriKind.Absolute);
                BitmapImage imageBitmap = new BitmapImage(imageUri);
                resim.Source = imageBitmap;
                yolAdres = value;
            }
            get
            {
                return yolAdres;
            }
        }
        public Brush Arkaplan
        {
            get
            {
                return arkarenk.Background;
            }
            set
            {

                arkarenk.Background = value;
            }
        }
        public SeraListe()
        {
            InitializeComponent();
        }

        private void arkarenk_MouseEnter(object sender, MouseEventArgs e)
        {

        }
    }
}
