using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7._0_Features
{
    class TupleChanges
    {
        static void Main(string[] args)
        {
            // Before C# 7.0
            Tuple<int, string, string> tuple = GetSomeValue();
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);
            Console.WriteLine(tuple.Item3);
            
            // Tuple
            var info1 = GetSomeValue1();
            Console.WriteLine(info1.id);
            Console.WriteLine(info1.name);
            Console.WriteLine(info1.city);
            Console.WriteLine("----------------------------------------");


            // Deconstruction
            (int customerId, string fullName, string livingCity) = GetSomeValue2();
            Console.WriteLine(customerId);
            Console.WriteLine(fullName);
            Console.WriteLine(livingCity);
            Console.WriteLine("----------------------------------------");


            // Deconstruction
            (int id, string fname, string city) = GetSomeValue3();
            Console.WriteLine(id);
            Console.WriteLine(fname);
            Console.WriteLine(city);
            Console.WriteLine("----------------------------------------");


            // Discard
            (_, string fname1, _) = GetSomeValue3();
            Console.WriteLine(fname1);
            Console.WriteLine("----------------------------------------");

            Console.ReadLine();
        }

        static Tuple<int, string, string> GetSomeValue()
        {
            return new Tuple<int, string, string>(123, "Praba", "KL");
        }
        
        static (int id, string name, string city) GetSomeValue1()
        {
            var a = (123, "Praba", "KL");
            return a;
        }

        static (int, string, string) GetSomeValue2()
        {
            var a = (123, "Praba", "KL");
            return a;
        }

        static (int id, string name, string city) GetSomeValue3()
        {
            var a = (123, "Praba", "KL");
            return a;
        }
    }
}
