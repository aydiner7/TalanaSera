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
    /// BildirimDenetleyicim.xaml etkileşim mantığı
    /// </summary>
    public partial class BildirimDenetleyicim : UserControl
    {
        public string Ad { get { return isim.Content.ToString(); } set { isim.Content = value; } }
        public string BildirimOzellik { get { return ozellik.Content.ToString(); } set { ozellik.Content = value; } }
        public string Aralik11 { get { return aralik1.Content.ToString(); } set { aralik1.Content = value; } }
        public string Aralik22 { get { return aralik2.Content.ToString(); } set { aralik2.Content = value; } }
        public string Tarih { get { return tarih2.Content.ToString(); } set { tarih2.Content = value; } }


        public string Yol
        {
            set
            {
                Uri imageUri = new Uri("c:/Talana/Images/"+value, UriKind.Absolute);
                BitmapImage imageBitmap = new BitmapImage(imageUri);
                resim.Source = imageBitmap;
            }
        }

        public BildirimDenetleyicim()
        {
            InitializeComponent();
        }
    }
}
