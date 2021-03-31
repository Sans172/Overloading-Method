using System;

namespace Overloading_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers number = new Numbers();

            Console.WriteLine("Minimum #1:  {0}", number.Findminimum(3, 1));
            Console.WriteLine("Minimum #2:  {0}", number.Findminimum(3,2,4));
            Console.WriteLine();
            Console.WriteLine("Maximum #1:  {0}", number.Findmaximum(3, 1));
            Console.WriteLine("Maximum #2:  {0}", number.Findmaximum(3, 2, 4));

            Console.ReadKey();

        }
    }
}
