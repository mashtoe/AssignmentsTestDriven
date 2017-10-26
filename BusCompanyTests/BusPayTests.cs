using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusCompany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusCompany.Tests
{
    [TestClass()]
    
    public class BusPayTests
    {
        [TestMethod()]
        public void TotalCostTest()
        {
            IBusPay busPay = new BusPay();

            Assert.AreEqual(130, busPay.TotalCost(0, 0));

        }

        [TestMethod()]
        public void TotalCostTest2Passengers()
        {
            IBusPay busPay = new BusPay();
            

            Assert.AreEqual(162, busPay.TotalCost(2, 10));
        }

        [TestMethod()]
        public void TotalCostAbove100LessThan500()
        {
            IBusPay busPay = new BusPay();

            Assert.AreEqual(410.5, busPay.TotalCost(2, 102));
        }

        [TestMethod()]
        public void TotalCostWith13Passengers()
        {
            IBusPay busPay = new BusPay();

            Assert.AreEqual(436, busPay.TotalCost(13, 102));
        }

        [TestMethod()]
        public void TotalCostAbove500()
        {
            IBusPay busPay = new BusPay();

            Assert.AreEqual(1259.5, busPay.TotalCost(13, 502));
        }
    }
}