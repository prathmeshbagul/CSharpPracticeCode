namespace June29
{class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            char ch = 'A';
            for (int i = 0; i <= rows; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(ch);
                    ch++;

                }
                Console.WriteLine();
            }

        }


    }
}


//5

//A
//BC
//DEF
//GHIJ
//KLMNO
