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
    /// Logika interakcji dla klasy RozneListyWindow.xaml
    /// </summary>
    public partial class RozneListyWindow : Window
    {
        public List<Produkt> Produkty { get; set; }
        public RozneListyWindow()
        {
            InitializeComponent();
            DataContext = this;
            Produkty = new List<Produkt>();
            Produkty.Add(new Produkt("azt", "papier techniczny", 123, "Zabrze"));
            Produkty.Add(new Produkt("br100", "blok rysunkowy", 300, "Zabrze"));
            Produkty.Add(new Produkt("bbb", "papier kancelaryjny", 200, "Zabrze"));
            Produkty.Add(new Produkt("bbb", "papier xero", 200, "Zabrze"));
            Produkty.Add(new Produkt("bbb", "papier kratka", 200, "Zabrze"));

        }
    }
}
