using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;


namespace ProjektObiektoweGUI
{
    [XmlInclude(typeof(Interesariusz))]
    public class Dostawca : Interesariusz
    {
        public static int licznikDost = 0;
        public int _idDost;
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