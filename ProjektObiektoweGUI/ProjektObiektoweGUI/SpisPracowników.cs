using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektObiektoweGUI
{
    class SpisPracowników //: Pracownik
    {
        static int liczbaPrac;
        static List<Pracownik> spis = new List<Pracownik>();
        static List<string> listaPrac = new List<string>();

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
    }
}
