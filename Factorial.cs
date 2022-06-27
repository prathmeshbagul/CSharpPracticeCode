namespace ConsoleApp3
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = FindFactorial(number);
            Console.WriteLine($"The factorial of {number} is {result}");

        }

        static int FindFactorial(int number)
        {
            int i, factorial = 1;

            for (i = 1; i <= number; i++)
            {

                factorial *= i;
            }

            return factorial;
        }
    }
}