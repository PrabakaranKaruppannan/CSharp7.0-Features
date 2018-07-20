using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7._0_Features
{
    class LocalFunction
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 1000000000; i++)
            {
                Console.WriteLine(SquaredOld(i));
            }

            
            /*for (int i = 1; i < 20; i++)
            {
                Console.WriteLine(Squared(i));
            }*/

            Console.Read();
        }

        public static int SquaredOld(int x)
        {
            return x * x;
        }

        public static int Squared(int x)
        {
            return sqrt(x);

            int sqrt(int i)
            {
                return i * i;
            }
        }
    }
}
