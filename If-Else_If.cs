using System;

namespace _23June
{
    class Program
    {   static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine("Absent");
            }
            else if (n > 0 && n < 40) 
            {
                Console.WriteLine("Fail"); 
            }
            else if (n >= 40 && n < 60) 
            { 
                Console.WriteLine("Grade-C");
            }
            else if (n >= 60 && n < 80) 
            { 
                Console.WriteLine("Grade-B");
            }
            else if (n >= 80 && n <= 100) 
            {
                Console.WriteLine("Grade-A");
            }
            else
            {
                Console.WriteLine("Grades Exceeding The Limit");
            }
        }

    }

}