using System;

namespace _4_И_циклы
{
    class Program
    {
        static double f(double x)
        {
            return (Math.Sqrt(1 - 0.4 * Math.Pow(x, 2)) - Math.Asin(x) );
        }

        static double f2(double x)
        {
            return (0.4 * Math.Pow((0.4 * Math.Pow(x, 2) + 1), -3/2) * (-x) * Math.Pow((1 - Math.Pow(x, 2)), -3/2) );

        }
        static void Main(string[] args)
        {
            double E = Convert.ToDouble(Console.ReadLine());
            double a = 0.2;
            double b = 0.9;

            double c = 0;
            double x = 0;
            if (f(a) * f2(a) > 0)
            {
                x = b;
                c = a;
            }
            else if (f(b) * f2(b) > 0)
            {
                x = a;
                c = b;
            }


            while (Math.Abs(f(x)) > E)
            {
                x = x - (f(x) * (x - c) / (f(x) - f(c)));
            }

            Console.WriteLine(x);
        }
    }
}
