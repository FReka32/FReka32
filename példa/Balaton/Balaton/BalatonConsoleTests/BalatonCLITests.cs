using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalatonConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalatonConsole.Tests
{
    [TestClass()]
    public class BalatonCLITests
    {
        [TestMethod()]
        public void Ado1()
        {
            int elvartErtek = 200 * 800;
            int szamitottErtek = BalatonConsole.BalatonCLI.Ado('A', 200);
            Assert.AreEqual(elvartErtek, szamitottErtek);
        }

        [TestMethod()]
        public void Ado2()
        {
            int elvartErtek = 200 * 600;
            int szamitottErtek = BalatonConsole.BalatonCLI.Ado('B', 200);
            Assert.AreEqual(elvartErtek, szamitottErtek);
        }

        [TestMethod()]
        public void Ado3()
        {
            int elvartErtek = 200 * 100;
            int szamitottErtek = BalatonConsole.BalatonCLI.Ado('C', 200);
            Assert.AreEqual(elvartErtek, szamitottErtek);
        }

        [TestMethod()]
        public void Ado4()
        {
            int elvartErtek =0;
            int szamitottErtek = BalatonConsole.BalatonCLI.Ado('C', 20);
            Assert.AreEqual(elvartErtek, szamitottErtek);
        }

    }
}