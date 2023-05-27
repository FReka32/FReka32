using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelsinkiConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelsinkiConsole.Tests
{
    [TestClass()]
    public class helsinki1952Tests
    {
        [TestMethod()]
        public void HelyezesbolPontszamTest1()
        {
            int elvart = 7;
            int szamitott = helsinki1952.HelyezesbolPontszam(1);
            Assert.AreEqual(elvart, szamitott);
        }

        [TestMethod()]
        public void HelyezesbolPontszamTest2()
        {
            int elvart = 5;
            int szamitott = helsinki1952.HelyezesbolPontszam(2);
            Assert.AreEqual(elvart, szamitott);
        }

        [TestMethod()]
        public void HelyezesbolPontszamTest7()
        {
            int elvart = 0;
            int szamitott = helsinki1952.HelyezesbolPontszam(7);
            Assert.AreEqual(elvart, szamitott);
        }
    }
}