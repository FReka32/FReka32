using Microsoft.VisualStudio.TestTools.UnitTesting;
using haromszogekCLI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haromszogekCLI.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void DerekszoguETest()
        {
            Assert.AreEqual(true, Program.DerekszoguE(3,4,5));
        }

    }
}