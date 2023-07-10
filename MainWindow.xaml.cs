using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace LicznikTArcicy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Oblicz(object sender, EventArgs e)
        {
            double dlugoscDeski = double.Parse(dlugoscDeskiTextbox.Text);
            double szerokoscDeski = double.Parse(szerokoscDeskiTextbox.Text);
            double wysokoscDeski = double.Parse(wysokoscDeskiTextbox.Text);
            double iloscDesek = double.Parse(iloscdesekTextbox.Text);
            double polePowierzchni = dlugoscDeski * szerokoscDeski * iloscDesek;
            double objetosc = dlugoscDeski * szerokoscDeski * wysokoscDeski * iloscDesek;
            PolePowierzchni.Content = "Pole powierzchni to: " + polePowierzchni.ToString() + " m2";
            Objetosc.Content = "Suma objętości to: " +  objetosc.ToString() + " m3";
        }
    }
}
