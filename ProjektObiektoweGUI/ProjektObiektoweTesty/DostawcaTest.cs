using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace ProjektObiektoweTesty
{
    class DostawcaTest
    {

        [Test]
        public void ToString_Test()
        {
            var s = new ProjektObiektoweGUI.Dostawca("Samsung", "ul. Armii Krajowej 12", "Warszawa", "00-142");

            var r = s.ToString();

            Assert.AreEqual("D-00000 Samsung ", r);
        }
    }
}

