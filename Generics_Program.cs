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
    class Program { 
        static void Main(string[] args)
        {
            Program1<String> name = new Program1<String>();
            name.value = "DSA";

            Program1<int> d = new Program1<int>();
            d.value = 12;

            Console.WriteLine(d.value);

            Console.WriteLine(name.value);
        }
    }
}
