using System;

namespace arrays04
{
    class Program
    {
        static void Main(string[] args)
        {
           Store store = new Store();

           Console.WriteLine(store["Table"]);
           Console.WriteLine(store[2]);
        }
    }
}
