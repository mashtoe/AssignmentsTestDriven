using Microsoft.VisualStudio.TestTools.UnitTesting;
using AssignmentsTestDriven;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsTestDriven.Tests
{
    [TestClass()]
    public class SortedBagTests
    {
        [TestMethod()]
        public void AddTest()
        {
            ISortedBag bag = new SortedBag();
            Assert.AreEqual(0,bag.Count);
            bag.Add(7);
            Assert.AreEqual(1,bag.Count);
            //int count = bag.Count;
        }

        [TestMethod()]
        public void GetTest()
        {
            ISortedBag bag = new SortedBag();
            bag.Add(20);
            bag.Add(17);
            bag.Add(17);
            bag.Add(-5);
            Assert.AreEqual(-5, bag.Get());
        }

        [TestMethod()]
        public void GetTest2()
        {
            ISortedBag bag = new SortedBag();
            try
            {
                int value = bag.Get();
                Assert.Fail();
            }
            catch (InvalidOperationException ex)
            {

            }
        }


        [TestMethod()]
        public void RemoveTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SizeTest()
        {
            Assert.Fail();
        }
    }
}