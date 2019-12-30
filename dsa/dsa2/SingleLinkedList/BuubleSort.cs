using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa2.SingleLinkedList
{
    class BuubleSort
    {
        public static void BubbleSortByData(Node start)
        {
            Node p;
            Node q;
            Node end;

            for (end = null; end != start.Next; end = p)
            {
                for (p = start; p.Next != end; p = p.Next)
                {
                    q = p.Next;
                    if (p.Value > q.Value)
                    {
                        int temp = q.Value;
                        q.Value = p.Value;
                        p.Value = temp;
                    }
                }
            }
        }

        public static void BubbleSortByReference(Node start)
        {
            Node p, q, end, r, temp;
            for (end = null; end != start.Next; end = p)
            {
                for (r = p = start; p.Next != end; r = p, p = p.Next)
                {
                    q = p.Next;
                    if (p.Value > q.Value)
                    {
                        p.Next = q.Next;
                        q.Next = p;
                        if (p != start)
                        {
                            r.Next = q;
                        }
                        else
                        {
                            start = q;
                        }

                        temp = p;
                        p = q;
                        q = temp;
                    }
                }
            }

        }
    }
}
