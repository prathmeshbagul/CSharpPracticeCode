using System;

namespace _23June
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculatePercentage(n:900,x:780,a:86) + " %");

        }

        static double CalculatePercentage(double x, double n)
        {

            double percentage = (x / n) * 100;
            return percentage;

        }

        static double CalculatePercentage(double x, double n, double a)
        {

            double percentage = ((x + a) / (n + 100)) * 100;
            return percentage;

        }
    }
}