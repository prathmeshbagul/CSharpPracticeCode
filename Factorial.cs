class Program
{

    static void Main(string[] args)
    {

        Console.WriteLine("Enter the number");
        FindFactorial();

    }

    static void FindFactorial()
    {
        int i, factorial = 1, number;

        number = Convert.ToInt32(Console.ReadLine());


        for (i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        Console.WriteLine("THE FACTORIAL OF " + number + " IS " + factorial);
    }
}