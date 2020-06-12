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
    /// SutunGrafik.xaml etkileşim mantığı
    /// </summary>
    public partial class SutunGrafik : UserControl
    {
        double ustLimit;
        double altLimit;
        public double s1 { get; set; }
        public double s2 { get; set; }
        public double s3 { get; set; }
        public double s4 { get; set; }
        public double s5 { get; set; }
        public double s6 { get; set; }
        public double s7 { get; set; }
        public double s8 { get; set; }
        public double s9 { get; set; }
        public double s10 { get; set; }
        public double s11 { get; set; }
        public double s12 { get; set; }
        public SutunGrafik()
        {
            InitializeComponent();
            
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            ustLimit = s1;
            altLimit = s1;
            if (ustLimit < s2)
                ustLimit = s2;
            if (ustLimit < s3)
                ustLimit = s3;
            if (ustLimit < s4)
                ustLimit = s4;
            if (ustLimit < s5)
                ustLimit = s5;
            if (ustLimit < s6)
                ustLimit = s6;
            if (ustLimit < s7)
                ustLimit = s7;
            if (ustLimit < s8)
                ustLimit = s8;
            if (ustLimit < s9)
                ustLimit = s9;
            if (ustLimit < s10)
                ustLimit = s10;
            if (ustLimit < s11)
                ustLimit = s11;
            if (ustLimit < s12)
                ustLimit = s12;

            if (altLimit > s2)
                altLimit = s2;
            if (altLimit > s3)
                altLimit = s3;
            if (altLimit > s4)
                altLimit = s4;
            if (altLimit > s5)
                altLimit = s5;
            if (altLimit > s6)
                altLimit = s6;
            if (altLimit > s7)
                altLimit = s7;
            if (altLimit > s8)
                altLimit = s8;
            if (altLimit > s9)
                altLimit = s9;
            if (altLimit > s10)
                altLimit = s10;
            if (altLimit > s11)
                altLimit = s11;
            if (altLimit > s12)
                altLimit = s12;

            Sa1.Content = altLimit;
            Sa6.Content = ustLimit;

            double ortalama = (ustLimit - altLimit) / 5;
            Sa2.Content = altLimit + (ortalama * 1);
            Sa3.Content = altLimit + (ortalama * 2);
            Sa4.Content = altLimit + (ortalama * 3);
            Sa5.Content = altLimit + (ortalama * 4);

            SOcak.Height = (193 / (ustLimit - altLimit)) * (s1 - altLimit) + 7;
            SSubat.Height = (193 / (ustLimit - altLimit)) * (s2 - altLimit) + 7;
            SMart.Height = (193 / (ustLimit - altLimit)) * (s3 - altLimit) + 7;
            SNisan.Height = (193 / (ustLimit - altLimit)) * (s4 - altLimit) + 7;
            SMayis.Height = (193 / (ustLimit - altLimit)) * (s5 - altLimit) + 7;
            SHaziran.Height = (193 / (ustLimit - altLimit)) * (s6 - altLimit) + 7;
            STemmuz.Height = (193 / (ustLimit - altLimit)) * (s7 - altLimit) + 7;
            SAgustos.Height = (193 / (ustLimit - altLimit)) * (s8 - altLimit) + 7;
            SEylul.Height = (193 / (ustLimit - altLimit)) * (s9 - altLimit) + 7;
            SEkim.Height = (193 / (ustLimit - altLimit)) * (s10 - altLimit) + 7;
            SKasim.Height = (193 / (ustLimit - altLimit)) * (s11 - altLimit) + 7;
            SAralik.Height = (193 / (ustLimit - altLimit)) * (s12 - altLimit) + 7;
        }
    }
}
