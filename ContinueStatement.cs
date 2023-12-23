using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LoopsInC_
{
    class ContinueinCsharp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the amount: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int sum = 0; 
            for(int i = 1; i < x; i += 2)
            {
                if(i % 9 == 0)
                {
                    // Continue Statement
                    continue;
                }
                sum += i;
            }
            Console.WriteLine("Sum of Odd Numbers is: " + sum);
        }
    }
}
