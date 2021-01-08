using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektObiektoweGUI
{
    class Transakcja
    {
        public enum Platformy { naszaStrona, Allegro, eBay, Amazon, AliExpress };
        public enum Rodzaje { Kupno, Sprzedaż };
        
        static int licznikTrans = 0;
        int _idTrans;
        Platformy _platforma;
        Rodzaje _rodzaj;
        decimal _cenaTrans;
        Telefon _obiektTrans;
        DateTime _dataTrans;
        //Dostawca _dostawca;
        //Odbiorca _odbiorca;
        Interesariusz _inter;
        Pracownik _prac;

        public Transakcja()
        {
            IdTrans = LicznikTrans;
            LicznikTrans++;
        }
/*
        public Transakcja(Platformy platforma, Rodzaje rodzaj, decimal cenaTrans, Telefon obiektTrans, DateTime dataTrans, Interesariusz inter) : this()
        {
            _platforma = platforma;
            _rodzaj = rodzaj;
            _cenaTrans = cenaTrans;
            _obiektTrans = obiektTrans;
            _dataTrans = dataTrans;
            //_dostawca = dostawca;
            //_odbiorca = odbiorca;
            _inter = inter;
        }*/

        public Transakcja(Platformy platforma, Rodzaje rodzaj, decimal cena, Telefon obiektTrans, DateTime dataTrans, Interesariusz inter, Pracownik prac) : this()
        {
            Platforma = platforma;
            Rodzaj = rodzaj;
            Cena = cena;
            ObiektTrans = obiektTrans;
            DataTrans = dataTrans;
            Inter = inter;
            Prac = prac;
        }

        public int LicznikTrans { get => LicznikTrans1; set => LicznikTrans1 = value; }
        public int IdTrans { get => _idTrans; set => _idTrans = value; }
        public Platformy Platforma { get => _platforma; set => _platforma = value; }
        public Rodzaje Rodzaj { get => _rodzaj; set => _rodzaj = value; }
        public decimal Cena { get => _cenaTrans; set => _cenaTrans = value; }
        internal Telefon ObiektTrans { get => _obiektTrans; set => _obiektTrans = value; }
        public DateTime DataTrans { get => _dataTrans; set => _dataTrans = value; }
        internal Interesariusz Inter { get => _inter; set => _inter = value; }
        internal Pracownik Prac { get => _prac; set => _prac = value; }
        public static int LicznikTrans1 { get => licznikTrans; set => licznikTrans = value; }
        //internal Dostawca Dostawca { get => _dostawca; set => _dostawca = value; }
        //internal Odbiorca Odbiorca { get => _odbiorca; set => _odbiorca = value; }
    }
}
