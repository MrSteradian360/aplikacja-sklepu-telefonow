using System;
using System.Collections.Generic;
using System.Text;


namespace ProjektObiektoweGUI
{

    public class Dostawca : Interesariusz
    {
        static int licznikDost = 0;
        int _idDost;
        public Dostawca(string nazwa, string adres, string miasto, string kodPocztowy) : base(nazwa, adres, miasto, kodPocztowy)
        {
            IdDost = LicznikDost;
            LicznikDost++;
        }

        public static int LicznikDost { get => licznikDost; set => licznikDost = value; }
        public int IdDost { get => _idDost; set => _idDost = value; }

        public override string ToString()
        {
            return String.Format("D-{0:D5} {1} ", this.IdDost, this.Nazwa.ToString());
        }
    }
}