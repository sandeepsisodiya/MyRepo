using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa2.Arrays.Sorting
{
    class BubbleSort
    {
        public static int[] BubbleSorting(int[] inputarr)
        {
            int i, j, temp;
            for (i = inputarr.Length - 2; i >= 0; i--)
            {
                for (j = 0; j <= i; j++)
                {
                    if(inputarr[j] > inputarr[j+1])
                    {
                        temp = inputarr[j];
                        inputarr[j] = inputarr[j + 1];
                        inputarr[j + 1] = temp;
                    }
                }
            }
            return inputarr;
        }
    }
}
