class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            char ch = 'A';
            for (int i = 1; i <= rows; i++)
            {
                for (int j = rows; j >= i; j--)
                {
                    Console.Write(ch);
                    ch++;

                }
                Console.WriteLine();
            }

        }


    }
    
//  5
// ABCDE
// FGHI
// JKL
// MN
// O