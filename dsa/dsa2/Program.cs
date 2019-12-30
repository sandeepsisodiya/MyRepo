using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dsa2.SingleLinkedList;

namespace dsa2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Single Linked List
            //SingleLinkedList.SingleLinkedList sll = new SingleLinkedList.SingleLinkedList();

            //sll.RemoveFromFront();
            //sll.AddByPosition(11, 1);
            //sll.AddAfter(8, 1);
            //sll.AddBefore(7, 1);
            //sll.AddToLast(1);
            //sll.AddToLast(2);
            //sll.AddToLast(3);
            //sll.AddToLast(4);
            //sll.AddToLast(5);

            //sll.AddBefore(6, 5);
            //sll.AddAfter(9, 2);
            //sll.AddByPosition(10, 3);
            //sll.Print();
            //Console.WriteLine("-----------------------------");
            //sll.RemoveFromFront();
            //sll.RemoveFromLast();
            //sll.Print();

            //Console.WriteLine("-----------------------------");
            //sll.RemoveAt(9);
            //sll.Print();

            //Console.WriteLine("-----------------------------");
            //sll.RemoveAt(8);
            //sll.Print();

            //Console.WriteLine("-----------------------------");
            //sll.RemoveAtIndex(6);
            //sll.Print();

            //Console.WriteLine("-----------------------------");
            //sll.ReverseLinkedList();
            //sll.Print();


            //Console.WriteLine("-----------------------------");
            ////sll.BubbleSortByData();
            //sll.BubbleSortByReference();
            //sll.Print();

            //Console.WriteLine("Hold");
            #endregion

            #region Arrays - Sorting

            Console.Write("Enter Array input: ");
            string str = Console.ReadLine();

            int[] intarr = Array.ConvertAll<string, int>(str.Split(' '), int.Parse);

            //dsa2.Arrays.Sorting.SelectionSort.SelectionSorting(intarr);

            dsa2.Arrays.Sorting.BubbleSort.BubbleSortig(intarr);

            Console.WriteLine("END");
            #endregion  
        }
    }
}
