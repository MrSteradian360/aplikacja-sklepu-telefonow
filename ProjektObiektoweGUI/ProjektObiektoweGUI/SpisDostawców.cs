using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektObiektoweGUI
{
    class SpisDostawców// : Dostawca
    {
        static int liczbaDost;
        static List<Dostawca> spisDost = new List<Dostawca>();
        static List<string> listaDost = new List<string>();

        public static int LiczbaDost { get => liczbaDost; set => liczbaDost = value; }
        public static List<Dostawca> SpisDost { get => spisDost; set => spisDost = value; }
        public static List<string> ListaDost { get => listaDost; set => listaDost = value; }

        static public void DodajDostawcę(Dostawca dostawca)
        {
            SpisDost.Add(dostawca);
            LiczbaDost++;
        }

        static public void UsuńDostawcę(Dostawca dostawca)
        {
            SpisDost.Remove(dostawca);
            LiczbaDost--;
        }

        static public void UsuńWszystkich()
        {
            SpisDost.Clear();
            LiczbaDost = 0;
        }

        static public bool JestDostawcą(Dostawca dostawca)
        {
            foreach (Dostawca t in SpisDost)
                if (t.Equals(dostawca)) return true;
            return false;
        }

    }
}
