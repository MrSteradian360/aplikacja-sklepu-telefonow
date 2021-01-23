using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace ProjektObiektoweGUI
{
    public class Telefon : IEquatable<Telefon>, ICloneable
    {
        static int licznikTel = 0;
        int _idTel;
        string _marka;
        string _model;
        string _szybkieładowanie;
        string _wodoodp;
        string _system;
        string _procesor;
        bool _sieć4G;
        bool _sieć5G;
        bool _dotykowy;
        bool _indukcyjne;
        bool _dualSIM;
        bool _NFC;
        decimal _wysokość;
        decimal _szerokość;
        decimal _grubość;
        decimal _przekątna;
        decimal _waga;
        decimal _cenaDetal;
        int _bateria;
        double _RAM ;
        double _ROM;
        int liczbaAparatów;
        int głównyAparat;
        string _bluetooth;
        
        
        public string Marka { get => _marka; set => _marka = value; }
        public string Model { get => _model; set => _model = value; }
        public string Szybkieładowanie { get => _szybkieładowanie; set => _szybkieładowanie = value; }
        public string Wodoodp { get => _wodoodp; set => _wodoodp = value; }
        public string Procesor { get => _procesor; set => _procesor = value; }
        public bool Dotykowy { get => _dotykowy; set => _dotykowy = value; }
        public bool Indukcyjne { get => _indukcyjne; set => _indukcyjne = value; }
        public bool DualSIM { get => _dualSIM; set => _dualSIM = value; }
        public decimal Wysokość { get => _wysokość; set => _wysokość = value; }
        public decimal Szerokość { get => _szerokość; set => _szerokość = value; }
        public decimal Grubość { get => _grubość; set => _grubość = value; }
        public decimal Przekątna { get => _przekątna; set => _przekątna = value; }
        public decimal Waga { get => _waga; set => _waga = value; }
        public decimal CenaDetal { get => _cenaDetal; set => _cenaDetal = value; }
        public int Bateria { get => _bateria; set => _bateria = value; }
        public double RAM { get => _RAM; set => _RAM = value; }
        public string System { get => _system; set => _system = value; }
        public double ROM { get => _ROM; set => _ROM = value; }
        public bool Sieć4G { get => _sieć4G; set => _sieć4G = value; }
        public bool Sieć5G { get => _sieć5G; set => _sieć5G = value; }
        public bool NFC { get => _NFC; set => _NFC = value; }
        public int IdTel { get => _idTel; set => _idTel = value; }
        public int LiczbaAparatów { get => liczbaAparatów; set => liczbaAparatów = value; }
        public string Bluetooth { get => _bluetooth; set => _bluetooth = value; }
        public int GłównyAparat { get => głównyAparat; set => głównyAparat = value; }
        public static int LicznikTel { get => licznikTel; set => licznikTel = value; }

        public Telefon()
        {
            this.IdTel = LicznikTel;
            LicznikTel++;
        }

        public Telefon(string marka, string model, string szybkieładowanie, string wodoodp, string system,
            string procesor, bool sieć4G, bool sieć5G, bool dotykowy, bool indukcyjne, bool dualSIM,
            bool NFC, decimal wysokość, decimal szerokość, decimal grubość, decimal przekątna, decimal waga,
            decimal cenaDetal, int bateria, double RAM, double ROM, int LiczbaAparatów, int głównyAparat, string bluetooth) : this()
        {
            this.Marka = marka;
            this.Model = model;
            this.Szybkieładowanie = szybkieładowanie;
            this.Wodoodp = wodoodp;
            this.System = system;
            this.Procesor = procesor;
            this.Sieć4G = sieć4G;
            this.Sieć5G = sieć5G;
            this.Dotykowy = dotykowy;
            this.Indukcyjne = indukcyjne;
            this.DualSIM = dualSIM;
            this.Wysokość = wysokość;
            this.Szerokość = szerokość;
            this.Grubość = grubość;
            this.Przekątna = przekątna;
            this.Waga = waga;
            this.CenaDetal = cenaDetal;
            this.Bateria = bateria;
            this.RAM = RAM;
            this.ROM = ROM;
            this.NFC = NFC;
            this.LiczbaAparatów = LiczbaAparatów;
            this.GłównyAparat = głównyAparat;
            this.Bluetooth = bluetooth;

        }

        public override string ToString()
        {
            return String.Format("T-{0:D5} {1} {2}", IdTel, Marka.ToString() , Model.ToString());
        }


        public int CompareTo(Telefon t)
        {
            string x1 = String.Format("{0} {1}", this.Marka, this.Model);
            string x2 = String.Format("{0} {1}", t.Marka, t.Model);
            return x1.CompareTo(x2);
        }

        public bool Equals(Telefon t)
        {
            string x1 = String.Format("{0} {1}", this.Marka, this.Model);
            string x2 = String.Format("{0} {1}", t.Marka, t.Model);
            return x1==x2;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

    }
}
