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
            Employee empOne = new Employee("TomTom");
            empOne.setSalary(1000);
            empOne.printEmp();

            /*
            Rectangle rec = new Rectangle();
            rec.Values(10.56, 5.35);
            Console.WriteLine("Area of the Rectangle");
            Console.WriteLine(rec.GetArea());
            Console.ReadKey();
            */
      
            /*
            ExplicitConversion conv = new ExplicitConversion();
            conv.Explicit_Conversion(456.97f, 45);
            conv.Explicit_Conversion_Result();
            Console.ReadKey();
            */
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
            Console.WriteLine("Length of Rectangle: " + length);
            Console.WriteLine("Width of Rectangle: " + width);
            return length * width;
        }
    }
}
