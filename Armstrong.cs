
using System;

namespace projectname1 {

    class Program {

        static void Main(string[] args) {

            int n, r, Sum = 0,t;
            Console.WriteLine("Enter The Number");
            n = Convert.ToInt32(Console.ReadLine());
            t=n;
            while (n > 0) {
                r = n % 10;
                Sum=Sum+(r*r*r);
                n=n/10;        
            
            
            }
            if (t == Sum)
            {
                Console.WriteLine("Number is Armstrong");
            }
            else {
                Console.WriteLine("Number is Not Armstrong");
                    }










        }
    
    
    
    }




}