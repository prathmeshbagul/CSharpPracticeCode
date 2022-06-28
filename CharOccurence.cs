 class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            string a = Console.ReadLine();
            Console.WriteLine("Enter the Character");
            char b = Convert.ToChar(Console.ReadLine());
            int occurence = CountOccurences(a, b);
            Console.WriteLine(occurence);
        }

        public static int CountOccurences(string a, char b)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b)

                    count++;
            }
            return count;
        }

    }