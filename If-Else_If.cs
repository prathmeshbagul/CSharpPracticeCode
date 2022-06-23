using System;

namespace _23June
{
    class Program
    {
        static void Main(string[] args)
        {

            string result = DetermineGrade();
            Console.WriteLine(result);
        }
        static string DetermineGrade()
        {
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
            {
                return "Absent";
            }
            else if (n > 0 && n < 40)
            {
                return "Fail";
            }
            else if (n >= 40 && n < 60)
            {
                return "Grade-C";
            }
            else if (n >= 60 && n < 80)
            {
                return "Grade-B";
            }
            else if (n >= 80 && n <= 100)
            {
                return "Grade-A";
            }
            else
            {
                return "Grades Exceeding The Limit";
            }
        }



    }
}