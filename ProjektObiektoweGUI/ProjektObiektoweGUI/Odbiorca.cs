using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektObiektoweGUI
{
    public class Odbiorca : Interesariusz
    {
        static int licznikOdb = 0;
        int _idOdb;

        public Odbiorca(string nazwa, string adres, string miasto, string kodPocztowy) : base(nazwa, adres, miasto, kodPocztowy)
        {
            IdOdb = LicznikOdb;
            LicznikOdb++;
        }

        public static int LicznikOdb { get => licznikOdb; set => licznikOdb = value; }
        public int IdOdb { get => _idOdb; set => _idOdb = value; }

        public override string ToString()
        {
            return string.Format("O-{0:D5} {1} ", this.IdOdb, this.Nazwa.ToString());
        }
    }
    
}
