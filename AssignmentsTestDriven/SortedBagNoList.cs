using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsTestDriven
{
    public class SortedBagNoList : ISortedBag
    {
        public int Count { get; set; }
        private BagItem min;

        public void Add(int number)
        {
            BagItem item = new BagItem()
            {
                Value = number
            };
            if (min != null)
            {
                if (item.Value <= min.Value)
                {
                    item.NextInLine = min;
                    min = item;
                }
                else
                {
                    BagItem current = min;
                    while (true)
                    {
                        if (current.NextInLine == null)
                        {
                            //We are at the end of the line
                            current.NextInLine = item;
                            break;
                        }
                        else
                        {
                            if (item.Value > current.NextInLine.Value)
                            {
                                current = current.NextInLine;
                            }
                            else
                            {
                                item.NextInLine = current.NextInLine;
                                current.NextInLine = item;
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                min = item;
            }
            Count++;
        }

        public int Get()
        {
            //if (min != null)
            //{
            //    int minNumber = min.Value;
            //    min = min.NextInLine;
            //    Count--;
            //    return minNumber;
            //}
            //else
            //{
            //    return -1;
            //}
            if (min != null)
            {
                return min.Value;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public void Remove()
        {
            if (min != null)
            {
                int minNumber = min.Value;
                min = min.NextInLine;
                Count--;
            }
        }
    }
}

