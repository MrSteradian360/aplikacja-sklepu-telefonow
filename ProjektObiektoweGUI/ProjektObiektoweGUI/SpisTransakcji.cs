using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace ProjektObiektoweGUI
{
    class SpisTransakcji// : transakcja
    {
        static int liczbaTrans;
        static List<Transakcja> spisTrans = new List<Transakcja>();
        static List<string> listaTrans = new List<string>();

        public static int LiczbaTrans { get => liczbaTrans; set => liczbaTrans = value; }
        public static List<Transakcja> SpisTrans { get => spisTrans; set => spisTrans = value; }
        public static List<string> ListaTrans { get => listaTrans; set => listaTrans = value; }

        static public void DodajTransakcję(Transakcja transakcja)
        {
            SpisTrans.Add(transakcja);
            LiczbaTrans++;
        }

        static public void UsuńTransakcję(Transakcja transakcja)
        {
            SpisTrans.Remove(transakcja);
            LiczbaTrans--;
        }

        static public void UsuńWszystkie()
        {
            SpisTrans.Clear();
            LiczbaTrans = 0;
        }

        static public bool JestTransakcją(Transakcja transakcja)
        {
            foreach (Transakcja t in SpisTrans)
                if (t.Equals(transakcja)) return true;
            return false;
        }

    }
}
