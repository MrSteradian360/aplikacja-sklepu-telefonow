using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace ProjektObiektoweGUI
{
    public class SpisPracowników //: Pracownik
    {
        public static int liczbaPrac;
        public static List<Pracownik> spis = new List<Pracownik>();
        public static List<string> listaPrac = new List<string>();

        public static int LiczbaPrac { get => liczbaPrac; set => liczbaPrac = value; }
        public static List<Pracownik> Spis { get => spis; set => spis = value; }
        public static List<string> ListaPrac { get => listaPrac; set => listaPrac = value; }

        static public void DodajPracownika(Pracownik p)
        {
            Spis.Add(p);
            LiczbaPrac++;
        }

        static public void UsuńPracownika(Pracownik p)
        {
            Spis.Remove(p);
            LiczbaPrac--;
        }

        static public void UsuńWszystkich()
        {
            Spis.Clear();
            LiczbaPrac = 0;
        }

        static public bool JestPracownikiem(Pracownik p)
        {
            foreach (Pracownik prac in Spis)
                if (prac.Equals(p)) return true;
            return false;
        }

        public void ZapiszXML(string nazwaPliku)
        {
            using (StreamWriter writer = new StreamWriter(nazwaPliku))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(SpisPracowników));
                serializer.Serialize(writer, this);
            }
        }

        public static SpisPracowników OdczytajXML(string nazwaPliku)
        {
            using (StreamReader reader = new StreamReader(nazwaPliku))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(SpisPracowników));
                return serializer.Deserialize(reader) as SpisPracowników;
            }
        }
    }
}
