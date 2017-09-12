using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsTestDriven
{
    public interface ISortedBag
    {
        int Count{ get; }

        void Add(int value);
        void Remove();
        int Get();
        
    }
}
