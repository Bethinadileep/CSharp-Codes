using System;

namespace LoopsInC_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x= ");
            int x = int.Parse(Console.ReadLine());
            decimal factorial = 1;
            do
            {
                factorial = factorial * x;
                x--;
            } while (x > 0);
            Console.WriteLine($"The Factorial is: {factorial}");
            Console.ReadLine();

        }
    }
}

//Factorial Using Recursion
using System;

namespace LoopsInC_
{
    class Program
    {
        static int Factorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = Factorial(number);
            Console.WriteLine($"Factorial of {number} is : {result}");

        }
    }
}
