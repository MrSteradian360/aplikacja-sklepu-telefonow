using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektObiektoweGUI
{
    public class Pracownik : Interesariusz
    {
        static int licznikPrac = 0;
        int _idPrac;
        string _PESEL;

        public Pracownik(string nazwa, string adres, string miasto, string kodPocztowy) : base(nazwa, adres, miasto, kodPocztowy)
        {
            IdPrac = LicznikPrac;
            LicznikPrac++;
        }

        public Pracownik(string nazwa, string adres, string miasto, string kodPocztowy, string pESEL) : this(nazwa, adres, miasto, kodPocztowy)
        {
            PESEL = pESEL;
        }

        public int LicznikPrac { get => licznikPrac; set => licznikPrac = value; }
        public int IdPrac { get => _idPrac; set => _idPrac = value; }
        public string PESEL { get => _PESEL; set => _PESEL = value; }

        public override string ToString()
        {
            return String.Format("P-{0:D5} {1}", this.IdPrac, this.Nazwa);
        }
    }
}
