using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaProd3P
{
    public class Produkt
    {
        public string Symbol { get; set; }
        public string Nazwa { get; set; }
        public int LiczbaSztuk { get; set; }
        public string Magazyn { get; set; }

        public Produkt(string symbol, string nazwa, int liczbaSztuk, string magazyn)
        {
            Symbol = symbol;
            Nazwa = nazwa;
            LiczbaSztuk = liczbaSztuk;
            Magazyn = magazyn;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}",Symbol,Nazwa,LiczbaSztuk,Magazyn);
        }
    }
}
