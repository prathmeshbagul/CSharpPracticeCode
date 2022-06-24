namespace ConsoleApp24June
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number");

            int n = Convert.ToInt32(Console.ReadLine());

            int result = IdentifyArmstrong(n);

            if (n == result)
            {
                Console.WriteLine("Number is Armstrong");
            }
            else
            {
                Console.WriteLine("Number is Not Armstrong");
            }

        }
        static int IdentifyArmstrong(int n)
        {

            int r, Sum = 0, t;
            t = n;
            while (n > 0)
            {
                r = n % 10;
                Sum = Sum + (r * r * r);
                n = n / 10;

            }
            return Sum;
        }

    }

}