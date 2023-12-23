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
Types of Loops
1)While Loops
2)Do while loop
3)for loop
4)Foreach loop
5)Nested for loop
6)Break 
7)Continue
8)Switch


Gods word

Jesus Told love who hate you and dishonour you. pray for them in jesus name
Jechariah 9 : 12
Return to your fortress, you prisoners of hope even now i announce that I will restore twice as much to you.

    https://www.youtube.com/watch?v=yMOjBupmP2A
https://www.youtube.com/shorts/NZwnjfLFw2E
