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
using System.Windows.Shapes;

namespace ListaProd3P
{
    /// <summary>
    /// Logika interakcji dla klasy SzczegolyWindow.xaml
    /// </summary>
    public partial class SzczegolyWindow : Window
    {
        private ListaProduktowWindow listaWindow = null;
        private bool czyNowy = false;
        public SzczegolyWindow()
        {
            InitializeComponent();
        }
        public SzczegolyWindow(ListaProduktowWindow listaWin)
        {
            InitializeComponent();
            this.listaWindow = listaWin;
            PrzygotujWiazanie();
        }

        public SzczegolyWindow(ListaProduktowWindow listaW, bool czyNowy)
        {
            InitializeComponent();
            this.listaWindow = listaW;
            this.czyNowy = czyNowy;
            PrzygotujWiazanie();
        }
        private void PrzygotujWiazanie()
        {
            Produkt produktZListy = null;
            if (czyNowy == true)
            {
                produktZListy = new Produkt("", "", 0, "");
                listaWindow.ListaProduktow.Add(produktZListy);
            }
            else
            {
                produktZListy = listaWindow.listaProdukty.SelectedItem as Produkt;
            }
            if (produktZListy != null)
            {
                gridProdSzcz.DataContext = produktZListy;
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            this.Close();
        }
    }
}
