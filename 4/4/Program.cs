using System;

namespace _5_КМВ_циклы
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            double x = Convert.ToDouble(input[0]);
            double E = Convert.ToDouble(input[1]);

            double sum = 0;
            int n = 0;
            double part = Math.Pow(x/2, 2);

            while (Math.Abs(part) > E)
            {
                sum += part;
                part = -part * x * x / ((n + 2) * (n + 2) * 4);
                n++;
            }

            Console.WriteLine(sum);
        }
    }
}
