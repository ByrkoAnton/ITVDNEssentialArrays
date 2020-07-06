using System;

namespace arrays02
{
    class Arr
    {
        private int[] arr;

        public Arr(int size)
        {
            arr = new int[size];
            Random random=new Random();
            for (int i=0; i<arr.Length; i++)
            {
                arr[i] = random.Next(-110, 200);
            }
        }

        public void ShowArr()
        {
            foreach (var elem in arr)
            {
                Console.Write(elem + " ");
            }

            Console.WriteLine();
        }

        public int GetMax()
        {
            int max = arr[0];
            foreach (var elem in arr)
            {
                if (elem > max) max = elem;
            }

            return max;
        }

        public int GetMin()
        {
            int min = arr[0];
            foreach (var elem in arr)
            {
                if (elem < min) min = elem;
            }

            return min;
        }

        public int GetSumAllElem()
        {
            int sum = 0;
            foreach (var elem in arr)
            {
                sum+= elem;
            }

            return sum;
        }

        public double GetAverage()
        {
            return GetSumAllElem() / (double) arr.Length;
        }

        public void ShowAllOdd()
        {
            foreach (var elem in arr)
            {
                if (elem % 2 !=0)
                { 
                    Console.Write(elem + " ");
                }
                
            }

            Console.WriteLine();
        }
    }
}
