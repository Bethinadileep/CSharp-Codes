using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1.OOPs
{
    //Encapsulation
    class Employee
    {
        private double salary;
        public double bonus { private set; get; }

        //public double Getbonus()
        //{
        //    return bonus;
        //}
        public void SetSalary(double salary, double bonus)
        {
            if(salary < 400000 && salary > 15000 ) {
                Console.WriteLine("Please check salary");
                this.salary = 0;
                this.bonus = 0;
            }
            else
            {
                this.salary = salary;
                this.bonus = bonus;
            }
        }
        public void CalculateTotalPrice()
        {
            double totalpay = salary + bonus;
            Console.WriteLine(totalpay);
        }
    }
    class Inheritance
    {
        static void Main(String[] args)
        {
            Employee Alex = new Employee();
            Employee Blex = new Employee();

            Alex.SetSalary(9000, 1000);
            Blex.SetSalary(5000, 4500);

            Alex.CalculateTotalPrice(); 
            Blex.CalculateTotalPrice();


            Console.WriteLine("Bonus Amount is : "+ Alex.bonus);
        }
    }
}


//Encapsulation is Data Hiding, it does not mean complete data hiding it is about not getting the data manipulated and not provide wrong data.
