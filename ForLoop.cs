using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsInC_
{
    class forloop
    {
        static void Main(string[] args) {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Printing from 1 to 10:" + i);
            }
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach(int i in numbers)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine("");
            string[] str = { "A", "B", "C", "D", "E", "F", "M" };
            foreach(string s in str)
            {
                Console.Write(" " + s);
            }
            Console.WriteLine("");

            //Nested For Loop
            //Printing Star Pattern
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
