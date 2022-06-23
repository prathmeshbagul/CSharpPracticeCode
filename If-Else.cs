using System;

namespace _23June
{
        class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0) 
            {
                Console.WriteLine("It is Even Number");
            }
            else 
            {
                Console.WriteLine("It is Odd Number");
            }
        }

    }

}