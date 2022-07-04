  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number Of rows");
            int rows = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)

                {

                    {
                        Console.Write((char)(j + 64));
                    }

                }

                Console.WriteLine();

            }
        }

    }
//6
//A
//AB
//ABC
//ABCD
//ABCDE
//ABCDEF