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
    /// BilgiPanel.xaml etkileşim mantığı
    /// </summary>
    public partial class BilgiPanel : UserControl
    {
        public string baslik
        {
            get { return BBaslik.Content.ToString(); }

            set
            {
                BBaslik.Content = value;
            }
        }

        public string icerik
        {
            get { return BIcerik.Content.ToString(); }

            set
            {
                BIcerik.Content = value;
            }
        }

        public string bilgi
        {
            get { return BBilgi.Content.ToString(); }

            set
            {
                BBilgi.Content = value;
            }
        }

        public String yol
        {
            set
            {
                Uri uri = new Uri(value, UriKind.Relative);
                BitmapImage bitmapImage = new BitmapImage(uri);
                BResim.Source = bitmapImage;
            }
        }
        public BilgiPanel()
        {
            InitializeComponent();
        }
    }
}
