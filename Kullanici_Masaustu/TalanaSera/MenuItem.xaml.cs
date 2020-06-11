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
    /// MenuItem.xaml etkileşim mantığı
    /// </summary>
    public partial class MenuItem : UserControl
    {
        public string ad { get { return isim.Content.ToString(); } set { isim.Content = value; } }
        public string yol { set
            {
                Uri imageUri = new Uri(value, UriKind.Relative);
                BitmapImage imageBitmap = new BitmapImage(imageUri);
                resim.Source = imageBitmap;
            } }
        public Brush arkaplan { get
            {
                return arkarenk.Background;
            }
            set {

                arkarenk.Background =value;
            } }
        public MenuItem()
        {
            InitializeComponent();
        }

       

       
    }
}
