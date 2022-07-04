class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number Of rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            

            for (int i = 0; i <=rows; i++)
            {

                for (int j = 1; j <=rows-i; j++)

                    Console.Write(" ");
                for (int j = 1;j<=2*i-1; j++)
                
                    Console.Write("*");
                
                            
                Console.WriteLine();

               

            }
            
        }

    }