//Coded by: Bethina Dileep
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Collections.Generic;

namespace Internal_2
{
    class Program1<T>
    {
        //using data members
        private T data;

        //using properties
        public T value
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }
    }
    class GFG
    {
        public void Display<TypeOfValue>(string msg, TypeOfValue value)
        {
            Console.WriteLine("{0}:{1}",msg,value);
        }
    }
    class Program { 
        static void Main(string[] args)
        {
            GFG obj = new GFG();
            obj.Display<int>("Jim", 12);
            obj.Display<string>("Java", "Programming");
            obj.Display<double>("C#",2.1);
            Program1<String> name = new Program1<String>();
            name.value = "Tom";

            Program1<int> d = new Program1<int>();
            d.value = 12;

            Console.WriteLine(d.value);

            Console.WriteLine(name.value);
        }
    }
}
