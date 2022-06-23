using System;

namespace _23June
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(GiveRemark());
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
                return "Marks Exceeding The Limit";
            }
        }
        static string GiveRemark()
        {
            string remark = DetermineGrade();
            if (remark == "Absent" || remark == "Fail")
            {
                return "Try Again";
            }
            else if (remark == "Grade-C" || remark == "Grade-B")
            {
                return "Good, But Improve Next Time ";
            }
            else if (remark == "Grade-A")
            {
                return "Keep It Up";
            }
            else
            {
                return "Typo Error ";
            }
        }



    }
}