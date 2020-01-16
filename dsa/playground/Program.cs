using System;

namespace playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Int array

            int[] ia = new int[10];

            //for (int i = ia.Length - 1; i >= 0; i--)
            //{
               // Console.WriteLine(i);
            //}

            string[] stra = new string[10];

            for(int i=0; i<=stra.Length-1; i++)
            {
                stra[i] = "Sandeep";
            }
 
            //Console.Write("Enter Array input: ");
            //string str = Console.ReadLine();

            //int[] intarr = Array.ConvertAll<string, int>(str.Split(' '), int.Parse);

            //dsa2.Arrays.Sorting.SelectionSort.SelectionSorting(intarr);

            Console.WriteLine("END");
        }
    }
}
