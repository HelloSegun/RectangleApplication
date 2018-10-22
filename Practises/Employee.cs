using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApplication.Practises
{
    class Employee
    {
        public String name;
        private double salary;

        public Employee(String empname)
        {
            name = empname;
        }

        public void setSalary(double empsal)
        {
            salary = empsal;
        }

        public void printEmp()
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("salary : {0}", salary);
            //Console.ReadKey();
        }
    }
}
