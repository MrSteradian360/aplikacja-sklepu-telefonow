using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektObiektoweGUI
{
    class SpisOdbiorców// : Odbiorca
    {
        static int liczbaOdb;
        static List<Odbiorca> spisOdb = new List<Odbiorca>();
        static List<string> listaOdb = new List<string>();

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

    }
}
