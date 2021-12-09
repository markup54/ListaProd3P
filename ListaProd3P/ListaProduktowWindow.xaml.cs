using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Logika interakcji dla klasy ListaProduktowWindow.xaml
    /// </summary>
    public partial class ListaProduktowWindow : Window
    {
        private ObservableCollection<Produkt> ListaProduktow = null;
            public ListaProduktowWindow()
        {
            InitializeComponent();
            PrzygotujWiazanie();
        }

        private void PrzygotujWiazanie()
        {
            ListaProduktow = new ObservableCollection<Produkt>();
            ListaProduktow.Add(new Produkt("ZXC", "monitor lcd", 1, "Zabrze"));
            ListaProduktow.Add(new Produkt("1234", "klawiatura", 15, "Zabrze"));
            ListaProduktow.Add(new Produkt("DZ-x", "myszka", 15, "Gliwice"));
            ListaProduktow.Add(new Produkt("ML-2160", "drukarka", 5, "Gliwice"));
            listaProdukty.ItemsSource = ListaProduktow;
        }

        private void ListaProdukty_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            SzczegolyWindow okno = new SzczegolyWindow(this);
            //okno.Show(); można otworzyć dowolną liczbę okien niewskazane
            okno.ShowDialog();
        }

        private void listaProdukty_KeyUp(object sender, KeyEventArgs e)
        {
            Produkt produktZListy = listaProdukty.SelectedItem as Produkt;
            MessageBoxResult odpowiedz = MessageBox.Show(" Czy na pewno chcesz usunąć "
                + produktZListy.ToString() + "?","Pytanie",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);
            if(odpowiedz == MessageBoxResult.Yes)
            {
                //MessageBox.Show("usuwanako");
                ListaProduktow.Remove(produktZListy);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("dodawanie produktu");
        }
    }
}
