using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Runtime.InteropServices.WindowsRuntime;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;
using System.Xml.Serialization;

namespace ProjektObiektoweGUI
{
    class MagazynTelefonów 
    {
        static int liczbaTel;
        static List<Telefon> magazyn = new List<Telefon>();
        static List<string> listaTel = new List<string>();

        public static int LiczbaTel { get => liczbaTel; set => liczbaTel = value; }
        public static List<Telefon> Magazyn { get => magazyn; set => magazyn = value; }
        public static List<string> ListaTel { get => listaTel; set => listaTel = value; }

        static public void DodajTelefon(Telefon telefon)
        {
            Magazyn.Add(telefon);
            LiczbaTel++;
        }

        static public void UsuńTelefon(Telefon telefon)
        {
            Magazyn.Remove(telefon);
            LiczbaTel--;
        }

        static public void UsuńWszystkie()
        {
            Magazyn.Clear();
            LiczbaTel = 0; 
        }

        static public bool JestNaStanie(Telefon telefon)
        {
            foreach (Telefon t in Magazyn)
                if (t.Equals(telefon)) return true;
            return false;
        }

        List<Telefon> l;

        public void SortujPoNazwie()
        {
            l = new List<Telefon>(magazyn);
            l.Sort();
            magazyn = new List<Telefon>(l);
        }

        public void SortujPoCenie(bool odKonca = false)
        {
            if (!odKonca)
            {
                l = new List<Telefon>(magazyn);
                l.Sort(new PriceComparator());
                magazyn = new List<Telefon>(l);
            }
            else
            {
                l = new List<Telefon>(magazyn);
                l.Sort(new PriceComparator());
                l = Enumerable.Reverse(l).ToList();
                magazyn = new List<Telefon>(l);
            }
        }

        class PriceComparator : Comparer<Telefon>
        {
            public override int Compare(Telefon x, Telefon y)
            {
                return x.CenaDetal.CompareTo(y.CenaDetal);
            }
        }


        public void ZapiszBinarnie(string nazwaPliku)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(nazwaPliku, FileMode.Create);
            formatter.Serialize(stream, this);
            stream.Close();
        }

        public MagazynTelefonów Odczytaj(string nazwaPliku)
        {
            using Stream stream = new FileStream(nazwaPliku, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            return (MagazynTelefonów)formatter.Deserialize(stream);
        }

        public static MagazynTelefonów Kopiuj(MagazynTelefonów l)
        {
            using (MemoryStream memory_stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(memory_stream, l);
                memory_stream.Position = 0;
                return (MagazynTelefonów)formatter.Deserialize(memory_stream);
            }
        }

    }
}
