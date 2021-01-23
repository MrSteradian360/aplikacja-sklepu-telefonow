using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ProjektObiektoweGUI
{
    public class Transakcja
    {
        /*public enum Platformy { naszaStrona, Allegro, eBay, Amazon, AliExpress };
        public enum Rodzaje { Kupno, Sprzedaż };*/
        
        static int licznikTrans = 0;
        int _idTrans;
        /*public Platformy _platforma;
        public Rodzaje _rodzaj;*/
        string _platforma;
        string _rodzaj;
        decimal _cenaTrans;
        string _idTel;
        string _data;
        //Dostawca _dostawca;
        //Odbiorca _odbiorca;
        string _interesariusz;
        string _pracownik;

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

        public Transakcja(string platforma, string rodzaj, decimal cena, string idTel, string data, string interesariusz, string pracownik) : this()
        {
            this.Platforma = platforma;
            this.Rodzaj = rodzaj;
            this.Cena = cena;
            this.IdTel = idTel;
            this.Data = data;
            this.Interesariusz = interesariusz;
            this.Pracownik = pracownik;

        }

        public int LicznikTrans { get => LicznikTrans1; set => LicznikTrans1 = value; }
        public int IdTrans { get => _idTrans; set => _idTrans = value; }
        public string Platforma { get => _platforma; set => _platforma = value; }
        public string Rodzaj { get => _rodzaj; set => _rodzaj = value; }
        public decimal Cena { get => _cenaTrans; set => _cenaTrans = value; }
        internal string IdTel { get => _idTel; set => _idTel = value; }
        public string Data { get => _data; set => _data = value; }
        public string Interesariusz  { get => _interesariusz; set => _interesariusz = value; }
        public string Pracownik  { get => _pracownik; set => _pracownik = value; }
        public static int LicznikTrans1 { get => licznikTrans; set => licznikTrans = value; }
        //internal Dostawca Dostawca { get => _dostawca; set => _dostawca = value; }
        //internal Odbiorca Odbiorca { get => _odbiorca; set => _odbiorca = value; }

        public override string ToString()
        {
            return String.Format("TR-{0:D5} {1} {2} {3}", IdTrans, Data.ToString(), IdTel.ToString(), Cena.ToString());
        }
    }
}
