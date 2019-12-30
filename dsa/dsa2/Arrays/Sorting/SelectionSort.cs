using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa2.Arrays.Sorting
{
    static class SelectionSort
    {
        public static int[] SelectionSorting(int[] inputarr)
        {
            int minIndex, temp, i, j;

            for (i = 0; i < inputarr.Length-1; i++)
            {
                minIndex = i;
                for(j=i+1; j< inputarr.Length; j++)
                {
                    if(inputarr[j] < inputarr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if(i != minIndex)
                {
                    temp = inputarr[i];
                    inputarr[i] = inputarr[minIndex];
                    inputarr[minIndex] = temp;
                }
            }
            return inputarr;
        }
    }
}
