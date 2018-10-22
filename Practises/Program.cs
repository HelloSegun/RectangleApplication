using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApplication.Practises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Employee empOne = new Employee("TomTom");
            Employee empTwo = new Employee("SatNav");

            empOne.setSalary(1000);
            empOne.printEmp();
            
            empTwo.setSalary(2000);
            empTwo.printEmp();
            */

            Rectangle rec = new Rectangle();
            rec.Values(10.56, 5.35);
            rec.Display();

            /*
            ExplicitConversion conv = new ExplicitConversion();
            conv.Explicit_Conversion(456.97f, 45);
            conv.Explicit_Conversion_Result();
            */

            Console.ReadKey();
        }
    }

    class Rectangle
    {
        double length;
        double width;

        public void Values(double len, double wid)
        {
            length = len;
            width = wid;
        }

        public double GetArea()
        { 
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length of Rectangle: {0}", length);
            Console.WriteLine("Width of Rectangle: {0}", width);
            Console.WriteLine("Area of Rectangle: {0}", GetArea());
        }
    }
}
