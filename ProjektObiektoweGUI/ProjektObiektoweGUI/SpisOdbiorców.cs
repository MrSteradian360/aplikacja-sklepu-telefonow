using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace ProjektObiektoweGUI
{
    public class SpisOdbiorców// : Odbiorca
    {
        public static int liczbaOdb;
        public static List<Odbiorca> spisOdb = new List<Odbiorca>();
        public static List<string> listaOdb = new List<string>();

        public static int LiczbaOdb { get => liczbaOdb; set => liczbaOdb = value; }
        public static List<Odbiorca> SpisOdb { get => spisOdb; set => spisOdb = value; }
        public static List<string> ListaOdb { get => listaOdb; set => listaOdb = value; }

        static public void DodajOdbiorcę(Odbiorca odbiorca)
        {
            SpisOdb.Add(odbiorca);
            LiczbaOdb++;
        }

        static public void UsuńOdbiorcę(Odbiorca odbiorca)
        {
            SpisOdb.Remove(odbiorca);
            LiczbaOdb--;
        }

        static public void UsuńWszystkich()
        {
            SpisOdb.Clear();
            LiczbaOdb = 0;
        }

        static public bool JestOdbiorcą(Odbiorca odbiorca)
        {
            foreach (Odbiorca t in SpisOdb)
                if (t.Equals(odbiorca)) return true;
            return false;
        }

        public void ZapiszXML(string nazwaPliku)
        {
            using (StreamWriter writer = new StreamWriter(nazwaPliku))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(SpisOdbiorców));
                serializer.Serialize(writer, this);
            }
        }

        public static SpisOdbiorców OdczytajXML(string nazwaPliku)
        {
            using (StreamReader reader = new StreamReader(nazwaPliku))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(SpisOdbiorców));
                return serializer.Deserialize(reader) as SpisOdbiorców;
            }
        }
    }
}
