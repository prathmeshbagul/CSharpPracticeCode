    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            string a = (Console.ReadLine());
            string str = a.ToLower();
            //string str2 = a.ToUpper();
            Console.WriteLine("Enter the Character");
            char ch = Convert.ToChar(Console.ReadLine());
            int occurence = CountOccurences(str, ch.ToString().ToLower());
            Console.WriteLine(occurence);
        }
        public static int CountOccurences(string str, string ch)
        {
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString() == ch)

                    count++;
            }
            return count;
        }

    }
