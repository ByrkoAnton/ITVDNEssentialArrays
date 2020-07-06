using System;

namespace arrays02
{
    class Program
    {
        static void Main(string[] args)
        {
            Arr arr = new Arr(10);
            arr.ShowArr();
            Console.WriteLine("max = " + arr.GetMax());
            Console.WriteLine("min = " + arr.GetMin());
            Console.WriteLine("sum = " + arr.GetSumAllElem());
            Console.WriteLine("average = " + arr.GetAverage());
            arr.ShowAllOdd();
        }
    }
}
