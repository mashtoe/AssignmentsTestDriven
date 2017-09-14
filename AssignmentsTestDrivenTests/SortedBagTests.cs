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
            ISortedBag bag = new SortedBagNoList();
            Assert.AreEqual(0,bag.Count);
            bag.Add(7);
            Assert.AreEqual(1,bag.Count);
            //int count = bag.Count;
        }

        [TestMethod()]
        public void GetTest()
        {
            
            ISortedBag bag = new SortedBagNoList();
            bag.Add(20);
            bag.Add(17);
            bag.Add(17);
            bag.Add(-5);
            Assert.AreEqual(-5, bag.Get());
        }

        [TestMethod()]
        [ExpectedException(typeof (InvalidOperationException))]
        public void GetTest2()
        {
            ISortedBag bag = new SortedBagNoList();
           
                int value = bag.Get();
              
            
            
        }


        [TestMethod()]
        public void SmallestIntTest()
        {
            ISortedBag bag = new SortedBagNoList();
            bag.Add(1);
            bag.Add(2);
            bag.Add(3);
            Assert.AreEqual(1, bag.Get());
            bag.Remove();
            Assert.AreEqual(2, bag.Get());
        }

        [TestMethod()]
        public void RemoveAndCountTest()
        {
            ISortedBag bag = new SortedBag();
            bag.Add(1);
            bag.Add(2);
            bag.Add(3);
            Assert.AreEqual(3, bag.Count);
            bag.Remove();
            Assert.AreEqual(2, bag.Count);

        }

        [TestMethod()]
        public void RemoveAndCountWithTwoEqualInts()
        {

            ISortedBag bag = new SortedBagNoList();
            bag.Add(1);
            bag.Add(1);
            bag.Add(3);
            Assert.AreEqual(3, bag.Count);
            bag.Remove();
            Assert.AreEqual(2, bag.Count);
        }
    }
}