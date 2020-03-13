using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double k = Convert.ToDouble(Console.ReadLine());

            double part = 1;
            double sum = 0;
            for (int n = 1; n < k; n++)
            {
                part *= (-1) * Math.Pow(x, 2) * n * (n + 2) / (n + 1) / (n + 3);
                sum += part;
            }
        }
    }
}
