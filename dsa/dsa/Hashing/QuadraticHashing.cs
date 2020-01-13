using System;
namespace dsa.Hashing
{
    public class QuadraticHashing
    {

        int[] intarr;
        public QuadraticHashing(int n)
        {
            intarr = new int[n];
        }

        int count = 0;

        private int HashFunction(int item)
        {
            int index;
            index = item % intarr.Length;

            if (intarr[index] != 0)
            {
                for (int i = index; i < intarr.Length - 1; i = i * i)
                {
                    if (intarr[i] == 0)
                    {
                        return i;
                    }
                }

                for (int j = 0; j <= index - 1; j++)
                {
                    if (intarr[j] == 0)
                    {
                        return j;
                    }

                }

            }
            return index;
        }


        private int RetrieveHashFunction(int item)
        {
            int index;
            index = item % intarr.Length;

            if (intarr[index] != 0)
            {
                for (int i = index; i < intarr.Length - 1; i++)
                {
                    if (intarr[i] == item)
                    {
                        return i;
                    }
                }

                for (int j = 0; j <= index - 1; j++)
                {
                    if (intarr[j] == item)
                    {
                        return j;
                    }

                }

            }
            return index;
        }

        public void Add(int val)
        {
            //h[k,i] = h(k) +i % n;
            int index = HashFunction(val);
            if (intarr[index] == 0)
            {
                intarr[index] = val;
                count++;
            }
            else
            {
                Console.Write("Array is Full");
            }

        }

        public bool Contains(int val)
        {
            int index = RetrieveHashFunction(val);
            if (intarr[index] == val)
            {
                return true;
            }
            return false;
        }

        public int Count()
        {
            return count;
        }

        public void Print()
        {
            foreach (int item in intarr)
            {
                Console.WriteLine(item);
            }
        }


    }
}
