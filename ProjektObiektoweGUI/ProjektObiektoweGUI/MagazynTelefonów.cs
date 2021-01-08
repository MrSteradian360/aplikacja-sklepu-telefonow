using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektObiektoweGUI
{
    class MagazynTelefonów// : Telefon
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

    }
}
