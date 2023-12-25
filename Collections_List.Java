using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Collections
{
    partial class Collection
    {
        private int a;
        private int b;  
        // New way of Initialization.
        public Collection(int A, int B) => (a, b) = (A, B);
        public void LIST_Collection()
        {
            var names = new List<string>();
            names.Add("Development");
            names.Add("DSA");
            names.Add(".NET Developer");

            // Pinting the Loop
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine(a + " " + b);
        }

    }

    partial class Collection
    {
        public void List()
        {
           List<string> list = new List<string>() { "name","name2","name3","name4","name5"};
           foreach(var name in list)
            { 
                Console.Write(name + " ");
            }
            Console.WriteLine();

            list.Remove("name3");
           
            //Iterate through Index
            for(int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
            list.Add("name3");

            // Iterate through List
            foreach(string s in list)
            {
                Console.Write(s + " ");
            }
          

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Collection obj = new Collection(1,2);
            obj.List();

        }
    }
}
