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
            //LinkedList();
            DoublyLinkedList();
        }

        static void LinkedList()
        {
            LinkedList.LinkedList llst = new LinkedList.LinkedList();

            llst.AddLast(9);
            llst.AddLast(11);
            llst.AddLast(13);
            llst.AddLast(15);
            llst.AddLast(17);
            llst.AddLast(19);
            llst.AddLast(21);
            llst.AddLast(23);

            llst.PrintLinkedList(llst);
            Console.WriteLine("Remove 17");
            llst.Remove(17);
            llst.PrintLinkedList(llst);

            Console.WriteLine("Remove 13");
            llst.Remove(13);
            llst.PrintLinkedList(llst);

            Console.WriteLine("Remove 21");
            llst.Remove(21);
            llst.PrintLinkedList(llst);

            Console.WriteLine("Remove 23");
            llst.Remove(23);
            llst.PrintLinkedList(llst);

            Console.WriteLine("Remove 9");
            llst.Remove(9);
            llst.PrintLinkedList(llst);
  

            Console.Read();
        }

        static void DoublyLinkedList()
        {
            DoublyLinkedList.DoublyLinkedList dllst = new DoublyLinkedList.DoublyLinkedList();

            dllst.AddLast(9);
            dllst.AddLast(11);
            dllst.AddLast(13);
            dllst.AddLast(15);
            dllst.AddLast(17);
            dllst.AddLast(19);
            dllst.AddLast(21);
            dllst.AddLast(23);

            dllst.PrintDoublyLinkedList(dllst);
            Console.WriteLine("Remove 17");
            dllst.Remove(17);
            dllst.PrintDoublyLinkedList(dllst);

            Console.WriteLine("Remove 13");
            dllst.Remove(13);
            dllst.PrintDoublyLinkedList(dllst);

            Console.WriteLine("Remove 21");
            dllst.Remove(21);
            dllst.PrintDoublyLinkedList(dllst);

            Console.WriteLine("Remove 23");
            dllst.Remove(23);
            dllst.PrintDoublyLinkedList(dllst);

            Console.WriteLine("Remove 9");
            dllst.Remove(9);
            dllst.PrintDoublyLinkedList(dllst);

            Console.Read();
        }
    }
}
