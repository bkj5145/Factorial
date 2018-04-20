using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number that you would like the factorial for: ");

            int index = Int32.Parse(Console.ReadLine());
            int total =0;
            String factorial = "";

            for (int i = index; i >=1 ; i--)
            {
                if (i==index)
                {
                    factorial += i+"x";
                    total = i * (i - 1);
                }
                else if (i!=1)
                {
                    factorial += i + "x";
                    total = total * (i - 1);
                }
                else
                {
                    factorial += i;
                }


            }

            Console.WriteLine(factorial);
            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
