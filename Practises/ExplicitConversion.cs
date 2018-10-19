using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApplication.Practises
{
    class ExplicitConversion
    {
        int float_to_int;
        float int_to_float;

        public void Explicit_Conversion (float f_num, int i_num)
        {
            float_to_int = (int)f_num;
            int_to_float = (float)i_num;
        }

        public void Explicit_Conversion_Result ()
        {
            Console.WriteLine(float_to_int);
            Console.WriteLine(int_to_float);
            //Below is C# syntax
            //Console.WriteLine("New int: {0}, New float: {1}", float_to_int, int_to_float);
        }

    }
}
