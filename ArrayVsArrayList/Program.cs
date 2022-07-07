using System.Collections;

namespace ArrayVsArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Console.WriteLine("Declare the Size of an array");
            //int num = Convert.ToInt32(Console.ReadLine());
           
            int[] numbers = new int[4];
            numbers[0] = 1;
            numbers[1] = 2; 
            numbers[2] = 3; 
            numbers[3] = 4;

            //numbers[4] = 5;
            //numbers[5] = 6;
            

            //Console.WriteLine("Enter the data");

            //for (int i = 0; i < num; i++)
            //{

            //    int data = Convert.ToInt32(Console.ReadLine());
            //    numbers[i] = data;

            //}
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }


            Console.WriteLine();



            ///////////////////////////////
            
 
            
            Console.WriteLine();
            Console.WriteLine("Now in Arraylist ");
            Console.WriteLine();
            ArrayList list = new ArrayList();

            list.Add("Prathmesh");
            list.Add(109);
            list.Add("3.14");
            list.Add(9.8);
            list.Add(9.2);
            list.Add("Abhinn");
            list.Add(9.8);

            list.Remove(9.8);
            list.RemoveAt(3);
            list.Insert(1, "Bagul");


            

            foreach (var member in list)
            {
                Console.WriteLine(member);
            }
            Console.WriteLine();

            list.Reverse();

            foreach (var member in list)
            {
                Console.WriteLine(member);
            }

            Console.WriteLine(list.Capacity);
        }
    }
}