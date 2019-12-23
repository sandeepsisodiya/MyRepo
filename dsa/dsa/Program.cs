using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dsa.DoublyLinkedList;
using dsa.LinkedList;


namespace dsa
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList();
        }

        static void LinkedList()
        {
            LinkedList.LinkedList llst = new LinkedList.LinkedList();


            //PrintLinkedList(dllst);
            //dllst.AddFirst(3);
            //dllst.AddFirst(5);
            //dllst.AddFirst(7);
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
            void PrintLinkedList(LinkedList.LinkedList locadllst)
            {
                foreach (int val in locadllst.GetEnumrator())
                {
                    Console.WriteLine(val);
                }
            }
        }

        static void DoublyLinkedList()
        {
            DoublyLinkedList.DoublyLinkedList dllst = new DoublyLinkedList.DoublyLinkedList();


            //PrintLinkedList(dllst);
            //dllst.AddFirst(3);
            //dllst.AddFirst(5);
            //dllst.AddFirst(7);
            dllst.AddLast(9);
            dllst.AddLast(11);
            dllst.AddLast(13);
            dllst.AddLast(15);
            dllst.AddLast(17);
            dllst.AddLast(19);
            dllst.AddLast(21);
            dllst.AddLast(23);

            PrintLinkedList(dllst);
            Console.WriteLine("Remove 1");
            dllst.Remove(17);
            PrintLinkedList(dllst);

            Console.WriteLine("Remove 2");
            dllst.Remove(13);
            PrintLinkedList(dllst);

            Console.WriteLine("Remove 3");
            dllst.Remove(21);
            PrintLinkedList(dllst);

            Console.WriteLine("Remove 4");
            dllst.Remove(23);
            PrintLinkedList(dllst);
            Console.Read();


            Console.WriteLine("Remove 5");
            dllst.Remove(9);
            PrintLinkedList(dllst);
            Console.Read();
            void PrintLinkedList(DoublyLinkedList.DoublyLinkedList locadllst)
            {
                foreach (int val in locadllst.GetEnumrator())
                {
                    Console.WriteLine(val);
                }
            }
        }
    }
}
