using System;

class Program
{

    static void Main(string[] args)
    { FindFactorial();}

   static void FindFactorial(){
        int i=1, factorial=1, number;
        Console.WriteLine("Enter the number");
        number = Convert.ToInt32(Console.ReadLine());

        while (i <= number) { 
        factorial = factorial * i;
            i++;
        }

        Console.WriteLine("THE FACTORIAL OF " + number +" IS " + factorial);
    }
}

