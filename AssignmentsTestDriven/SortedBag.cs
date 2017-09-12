using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsTestDriven
{
    public class SortedBag : ISortedBag
    {
        public int Count {
            get { return bag.Count(); }
        }
        private List<int> bag;
        
        public SortedBag()
        {
            bag = new List<int>();
        }

        public void Add(int value)
        {
            bag.Add(value);
        }

        public int Get()
        {
            return bag.Min();
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }

        public int Size()
        {
            throw new NotImplementedException();
        }
    }
}
