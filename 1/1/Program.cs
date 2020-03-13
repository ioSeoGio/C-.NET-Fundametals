using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {

            double x = Convert.ToSingle(Console.ReadLine());
            double y = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine(Math.Pow(x + y, 2));
        }
    }
}
