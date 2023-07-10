using System;
using System.Windows;

namespace LicznikTArcicy
{
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
