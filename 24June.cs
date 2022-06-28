namespace _24June_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime today = DateTime.Today;
            //Console.WriteLine(today);
            //DateTime twoDayslater = today.AddDays(2);
            //Console.WriteLine(twoDayslater.ToString());
            //bool isDST = today.IsDaylightSavingTime();
            //Console.WriteLine(isDST);
            //DateTime hiredate = new DateTime(2022, 05, 18);
            //Console.WriteLine(hiredate);
            //DateTime joinDate = hiredate.AddDays(14);
            //Console.WriteLine(joinDate);
            //DateTime startHour = DateTime.Now;
            //TimeSpan workTime = new TimeSpan(8, 35, 0);
            //DateTime endHour = startHour.Add(workTime);
            //Console.WriteLine(startHour.ToLongDateString());
            //Console.WriteLine(endHour.ToLongDateString());

            //char newChar = 's';
            //Console.WriteLine(newChar);

            //int a = 10;
            //int b = a;
            //Console.WriteLine(b + a);
            string myString = "StartString";

            int l = myString.Length;
            string upper = myString.ToUpper();
            string lower = myString.ToLower();
            Console.WriteLine(upper);
            Console.WriteLine(lower);

            bool b = myString.Contains("rtstr"); // Ask ???
            Console.WriteLine(b);

            //  string s = myString.Replace("S", "t");
            //  Console.WriteLine(s);

            // string sub = myString.Substring(5, 6); //start from 5th and go for total 6 ahead.
            // Console.WriteLine(sub);

            string firstname = "Prathmesh";
            string lastname = "Bagul";
            string fullname = "my name is " + firstname + " " + lastname;
            string fullname2 = string.Format("Hello my name is {0}  and lastname is {1}", firstname, lastname);
            string fullname3 = $"Hi my name is {firstname} and lastname is {lastname}";
            Console.WriteLine(fullname);
            Console.WriteLine(fullname2);
            Console.WriteLine(fullname3);

            string empname = string.Concat(firstname, lastname);
            Console.WriteLine(empname);

            Console.WriteLine("Here are the employee details : \t Prathmesh \n Bagul ");

            string escapedFilePath = "C:\\documents";
            string marketingtagLine = "baking the \"best pies\" ever";
            Console.WriteLine(marketingtagLine);
            Console.WriteLine(escapedFilePath);

            string verbatimFilePath = @"C:\documents";
            // string verbatimTagline = @"baking the best pies ever" ; //Ask???
            Console.WriteLine(verbatimFilePath);
            //  Console.WriteLine(verbatimTagline);  // Ask???

            //  string Name = "Prathmesh";

            //  bool b1 = Name == "Prathmesh";
            // Console.WriteLine(b1);
            //  bool b2 = Name == "prathmesh";
            //   Console.WriteLine(b2);
            // bool b3 = Name.Equals("prathmesh");
            //   Console.WriteLine(b3);

            //string Name1 = "Prathmesh";
            //string Name2 = "PRATHMESH";

            //Console.WriteLine("Are both names equal ?" + (Name1 == Name2));
            //Console.WriteLine("Is names equal to bethany ?" + (Name1 == "Prathmesh"));
            //Console.WriteLine("Are both names equal ?" + Name2.Equals("PRATHMESH"));

            string index = string.Empty;
            for(int i = 0; i<20; i++)
            {
                index += i.ToString();
            }

            Console.WriteLine(index);




            Console.ReadLine();
        }


    }

}