using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace ProjektObiektoweTesty
{
    public class OdbiorcaTest
    {
        [Test]
        public void ToString_Test()
        {
            var s = new ProjektObiektoweGUI.Odbiorca("Paweł Lisicki", "ul. Kaskadowa 21D", "Kraków", "30-059");

            var r = s.ToString();

            Assert.AreEqual("O-00000 Paweł Lisicki ", r);
        }
    }
}
