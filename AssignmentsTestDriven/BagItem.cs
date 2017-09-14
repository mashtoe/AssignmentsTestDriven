using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsTestDriven
{
    class BagItem
    {
        public int Value { get; set; }
        public BagItem NextInLine { get; set; }
    }
}
