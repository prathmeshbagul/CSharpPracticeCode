namespace Handson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number Of rows");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("A");
                }
                Console.WriteLine();    

            }
        }
    }
}