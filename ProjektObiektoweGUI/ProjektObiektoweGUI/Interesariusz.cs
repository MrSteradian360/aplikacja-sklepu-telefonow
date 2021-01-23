using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektObiektoweGUI
{
    abstract public class Interesariusz
    {
        string _nazwa;
        string _kodPocztowy;
        string _miasto;
        string _adres;

        public Interesariusz(string nazwa, string adres, string miasto, string kodPocztowy)
        {
            Nazwa = nazwa;
            Adres = adres;
            Miasto = miasto;
            KodPocztowy = kodPocztowy;
        }

        public string Nazwa { get => _nazwa; set => _nazwa = value; }
        public string Adres { get => _adres; set => _adres = value; }
        public string Miasto { get => _miasto; set => _miasto = value; }
        public string KodPocztowy { get => _kodPocztowy; set => _kodPocztowy = value; }


    }
}
