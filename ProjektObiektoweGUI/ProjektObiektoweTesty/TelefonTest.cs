using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektObiektoweTesty
{
    public class TelefonTest
    {
        [Test]
        public void Telefon_Test()
        {
            var t = new ProjektObiektoweGUI.Telefon();

            Assert.That(ProjektObiektoweGUI.Telefon.LicznikTel, Is.EqualTo(1));

        }

        [Test]
        public void ToString_Test()
        {
            var t = new ProjektObiektoweGUI.Telefon("Samsung", "Galaxy Note 10",
                "Quick Charge 2.0", "IP68", "Android 9.0 Pie", "Samsung Exynos 9825",
                true, false, true, true, true, true,
                151.00m, 71.80m, 7.90m, 6.28m, 168.00m, 2999.00m, 3500, 8, 256, 4, 16, "v5.0");

            Assert.AreEqual("T-00001 Samsung Galaxy Note 10", t.ToString());
        }


    }
}
