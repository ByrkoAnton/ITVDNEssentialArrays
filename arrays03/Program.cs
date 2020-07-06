using System;

namespace arrays03
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix(3,7, true);
            matrix.ShowMatr();
            Console.WriteLine();
            matrix = matrix.ChangeSise(10,10);
            matrix.ShowMatr();
            Console.WriteLine();
            Matrix matrix2 = matrix.ChangeSise(5, 5);
            matrix2.ShowMatr();
        }
    }
}
