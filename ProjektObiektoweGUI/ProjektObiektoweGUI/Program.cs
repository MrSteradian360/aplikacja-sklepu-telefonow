using ProjektObiektoweGUI;
using System;
using System.Windows.Forms;

namespace ProjektObiektoweGUI
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("");
            //Console.WriteLine("");
            
            Telefon tel0 = new Telefon("Samsung", "Galaxy Note 10", "Quick Charge 2.0", "IP68", "Android 9.0 Pie", "Samsung Exynos 9825", true, false, true, true, true, true, 151.00m, 71.80m, 7.90m, 6.28m, 168.00m, 2999.00m, 3500, 8, 256, 4, 16, "v5.0");
            Telefon tel1 = new Telefon("Samsung", "Galaxy Note 10", "Quick Charge 2.0", "IP68", "Android 9.0 Pie", "Samsung Exynos 9825", true, false, true, true, true, true, 151.00m, 71.80m, 7.90m, 6.28m, 168.00m, 2999.00m, 3500, 8, 256, 4, 16, "v5.0");
            Telefon tel2 = new Telefon("Samsung", "Galaxy Note 10", "Quick Charge 2.0", "IP68", "Android 9.0 Pie", "Samsung Exynos 9825", true, false, true, true, true, true, 151.00m, 71.80m, 7.90m, 6.28m, 168.00m, 2999.00m, 3500, 8, 256, 4, 16, "v5.0");
            Telefon tel3 = new Telefon("Samsung", "Galaxy Note 10", "Quick Charge 2.0", "IP68", "Android 9.0 Pie", "Samsung Exynos 9825", true, false, true, true, true, true, 151.00m, 71.80m, 7.90m, 6.28m, 168.00m, 2999.00m, 3500, 8, 256, 4, 16, "v5.0");
            Telefon tel4 = new Telefon("Apple", "iPhone 12 Pro Max", "Quick Charge", "IP68", "Apple iOS 14", "Apple A14 Bionic", true, true, true, true, true, true, 160.80m, 78.10m, 7.40m, 6.70m, 226.00m, 7199.00m, 3687, 6, 512, 4, 16, "v5.0");
            Telefon tel5 = new Telefon("Apple", "iPhone 12 Pro Max", "Quick Charge", "IP68", "Apple iOS 14", "Apple A14 Bionic", true, true, true, true, true, true, 160.80m, 78.10m, 7.40m, 6.70m, 226.00m, 7199.00m, 3687, 6, 512, 4, 16, "v5.0");
            Telefon tel6 = new Telefon("Apple", "iPhone 12 Pro Max", "Quick Charge", "IP68", "Apple iOS 14", "Apple A14 Bionic", true, true, true, true, true, true, 160.80m, 78.10m, 7.40m, 6.70m, 226.00m, 7199.00m, 3687, 6, 512, 4, 16, "v5.0");
            Telefon tel7 = new Telefon("Apple", "iPhone 12 Pro Max", "Quick Charge", "IP68", "Apple iOS 14", "Apple A14 Bionic", true, true, true, true, true, true, 160.80m, 78.10m, 7.40m, 6.70m, 226.00m, 7199.00m, 3687, 6, 512, 4, 16, "v5.0");
            Telefon tel8 = new Telefon("Apple", "iPhone 12 Pro Max", "Quick Charge", "IP68", "Apple iOS 14", "Apple A14 Bionic", true, true, true, true, true, true, 160.80m, 78.10m, 7.40m, 6.70m, 226.00m, 7199.00m, 3687, 6, 512, 4, 16, "v5.0");
            Telefon tel9 = new Telefon("Redmi", "Note 9 Pro", "Fast Charging", null, "Android 10", "Qualcomm Snapdragon 720G", true, false, true, false, true, true, 165.75m, 76.68m, 8.80m, 6.67m, 209.00m, 1199.00m, 5020, 4, 64, 5, 48, "v5.0");
            Telefon tel10 = new Telefon("Redmi", "Note 9 Pro", "Fast Charging", null, "Android 10", "Qualcomm Snapdragon 720G", true, false, true, false, true, true, 165.75m, 76.68m, 8.80m, 6.67m, 209.00m, 1199.00m, 5020, 4, 64, 5, 48, "v5.0");
            Telefon tel11 = new Telefon("Redmi", "Note 9 Pro", "Fast Charging", null, "Android 10", "Qualcomm Snapdragon 720G", true, false, true, false, true, true, 165.75m, 76.68m, 8.80m, 6.67m, 209.00m, 1199.00m, 5020, 4, 64, 5, 48, "v5.0");
            Telefon tel12 = new Telefon("Redmi", "Note 9 Pro", "Fast Charging", null, "Android 10", "Qualcomm Snapdragon 720G", true, false, true, false, true, true, 165.75m, 76.68m, 8.80m, 6.67m, 209.00m, 1199.00m, 5020, 4, 64, 5, 48, "v5.0");
            Telefon tel13 = new Telefon("POCO", "X3 NFC", "Quick Charge", "IP53", "Android 10", "Qualcomm Snapdragon 732G", true, false, true, false, true, true, 165.30m, 76.80m, 9.40m, 6.67m, 215.00m, 1199.00m, 5160, 6, 128, 5, 64, "v5.0");
            Telefon tel14 = new Telefon("POCO", "X3 NFC", "Quick Charge", "IP53", "Android 10", "Qualcomm Snapdragon 732G", true, false, true, false, true, true, 165.30m, 76.80m, 9.40m, 6.67m, 215.00m, 1199.00m, 5160, 6, 128, 5, 64, "v5.0");
            Telefon tel15 = new Telefon("POCO", "X3 NFC", "Quick Charge", "IP53", "Android 10", "Qualcomm Snapdragon 732G", true, false, true, false, true, true, 165.30m, 76.80m, 9.40m, 6.67m, 215.00m, 1199.00m, 5160, 6, 128, 5, 64, "v5.0");
            Telefon tel16 = new Telefon("Xiaomi", "Mi 10T Pro 5G", "Fast Charging", null, "Android 10", "Qualcomm Snapdragon 865", true, true, true, false, true, true, 165.10m, 76.40m, 9.33m, 6.67m, 218.00m, 2799.00m, 5000, 8, 128, 4, 108, "v5.1");
            Telefon tel17 = new Telefon("Xiaomi", "Mi 10T Pro 5G", "Fast Charging", null, "Android 10", "Qualcomm Snapdragon 865", true, true, true, false, true, true, 165.10m, 76.40m, 9.33m, 6.67m, 218.00m, 2799.00m, 5000, 8, 128, 4, 108, "v5.1");
            Telefon tel18 = new Telefon("Xiaomi", "Mi 10T Pro 5G", "Fast Charging", null, "Android 10", "Qualcomm Snapdragon 865", true, true, true, false, true, true, 165.10m, 76.40m, 9.33m, 6.67m, 218.00m, 2799.00m, 5000, 8, 128, 4, 108, "v5.1");
            Telefon tel19 = new Telefon("Nokia", "3310", null, null, null, "MAD2WD1", false, false, false, false, false, false, 113.00m, 48.00m, 22.00m, 2.40m, 133.00m, 245.00m, 900, 0.01, 0.02, 0, 0, null);
            Telefon tel20 = new Telefon("Nokia", "3310", null, null, null, "MAD2WD1", false, false, false, false, false, false, 113.00m, 48.00m, 22.00m, 2.40m, 133.00m, 245.00m, 900, 0.01, 0.02, 0, 0, null);

            //MagazynTelefonów magazyn1 = new MagazynTelefonów();
            MagazynTelefonów.DodajTelefon(tel0);
            MagazynTelefonów.DodajTelefon(tel1);
            MagazynTelefonów.DodajTelefon(tel2);
            MagazynTelefonów.DodajTelefon(tel3);
            MagazynTelefonów.DodajTelefon(tel4);
            MagazynTelefonów.DodajTelefon(tel5);
            MagazynTelefonów.DodajTelefon(tel6);
            MagazynTelefonów.DodajTelefon(tel7);
            MagazynTelefonów.DodajTelefon(tel8);
            MagazynTelefonów.DodajTelefon(tel9);
            MagazynTelefonów.DodajTelefon(tel10);
            MagazynTelefonów.DodajTelefon(tel11); 
            MagazynTelefonów.DodajTelefon(tel12);
            MagazynTelefonów.DodajTelefon(tel13);
            MagazynTelefonów.DodajTelefon(tel14);
            MagazynTelefonów.DodajTelefon(tel15);
            MagazynTelefonów.DodajTelefon(tel16);
            MagazynTelefonów.DodajTelefon(tel17);
            MagazynTelefonów.DodajTelefon(tel18);
            MagazynTelefonów.DodajTelefon(tel19);
            MagazynTelefonów.DodajTelefon(tel20);

            Pracownik p0 = new Pracownik("Jan Kowalski","ul. Lipowa 12", "Zamość", "22-400", "10203040506");
            Pracownik p1 = new Pracownik("Adam Nowak", "ul. Brzozowa 13", "Kraków", "30-063", "20193948392");
            Pracownik p2 = new Pracownik("Paweł Wiśniewski", "ul. Miodowa 12", "Zamość", "22-400", "58329104854");
            Pracownik p3 = new Pracownik("Michał Wójcik", "ul. Morowa 12", "Zamość", "22-400", "64830284435");

            SpisPracowników.DodajPracownika(p0);
            SpisPracowników.DodajPracownika(p1);
            SpisPracowników.DodajPracownika(p2);
            SpisPracowników.DodajPracownika(p3);

            //Odbiorca
            Odbiorca odb0 = new Odbiorca("Paweł Lisicki", "ul. Kaskadowa 21D", "Kraków", "30-059");
            Odbiorca odb1 = new Odbiorca("Mikołaj Nowicki", "ul. Skalna 21D", "Kraków", "30-059");

            SpisOdbiorców.DodajOdbiorcę(odb0);
            SpisOdbiorców.DodajOdbiorcę(odb1);

            Dostawca dost0 = new Dostawca("Samsung", "ul. Armii Krajowej 12", "Warszawa", "00-142");
            Dostawca dost1 = new Dostawca("Xiaomi", "ul. Komarowa", "Warszawa", "00-102");

            SpisDostawców.DodajDostawcę(dost0);
            SpisDostawców.DodajDostawcę(dost1);

            //Form1 form1 = new Form1();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }   
}