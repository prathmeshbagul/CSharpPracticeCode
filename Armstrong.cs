﻿namespace June24
{
    class Program
    {

        static void Main(string[] args)
        {
            IdentifyArmstrong(153);
        }
        static string IdentifyArmstrong(int n)
        {
            int r, Sum = 0, t;
            t = n;
            while (n > 0)
            {
                r = n % 10;
                Sum = Sum + (r * r * r);
                n = n / 10;

            }
            if (t == Sum)
            {
                return "Number is Armstrong";
            }
            else
            {
                return "Number is Not Armstrong";
            }
        }

    }

}