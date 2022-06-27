namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number ");
            int x = Convert.ToInt32(Console.ReadLine());
            int result = IdentifyPalindrome(x);

            if (result == x)
            {
                Console.WriteLine("Palindrome Number");
            }
            else 
            {
                Console.WriteLine("Not Palindrome Number");
            }
        }
        public static int IdentifyPalindrome(int x)
        {
            int n, sum = 0, t;

            t = x;
            while (x > 0)
            {
                n = x % 10;
                sum = (sum * 10) + n;
                x = x / 10;
            }

            return sum;

        }
    }
}