using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7._0_Features
{
    class DigitSeparator
    {
        static void Main(string[] args)
        {
            int bin = 0b1001_1010_0001_0100;
            int hex = 0x1b_a0_44_fe;
            int dec = 33_554_432;
            int weird = 1_2__3___4____5_____6______7_______8________9;
            double real = 1_000.111_1e-1_000;

            Console.WriteLine(bin);
            Console.WriteLine(hex);
            Console.WriteLine(dec);
            Console.WriteLine(weird);
            Console.WriteLine(real);

            Console.Read();
        }
    }
}
