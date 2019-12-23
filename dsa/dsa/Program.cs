using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList llst = new LinkedList();


            //PrintLinkedList(llst);
            //llst.AddFirst(3);
            //llst.AddFirst(5);
            //llst.AddFirst(7);
            llst.AddLast(9);
            llst.AddLast(11);
            llst.AddLast(13);
            llst.AddLast(15);
            llst.AddLast(17);
            llst.AddLast(19);
            llst.AddLast(21);
            llst.AddLast(23);

            PrintLinkedList(llst);
            Console.WriteLine("Remove 1");
            llst.Remove(17);
            PrintLinkedList(llst);

            Console.WriteLine("Remove 2");
            llst.Remove(13);
            PrintLinkedList(llst);

            Console.WriteLine("Remove 3");
            llst.Remove(21);
            PrintLinkedList(llst);

            Console.WriteLine("Remove 4");
            llst.Remove(23);
            PrintLinkedList(llst);
            Console.Read();


            Console.WriteLine("Remove 5");
            llst.Remove(9);
            PrintLinkedList(llst);
            Console.Read();
            void PrintLinkedList(LinkedList locallst)
            {
                foreach (int val in locallst.GetEnumrator())
                {
                    Console.WriteLine(val);
                }
            }

        }
    }
}
