﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7._0_Features
{
    class OutChanges
    {
        static void Main(string[] args)
        {
            string firstName = "Praba";
            int convertedValue = 0;
            if (int.TryParse(firstName, out convertedValue))
            {
                Console.WriteLine("Conversion not succeeded");
            }
            else
            {
                Console.WriteLine("Conversion succeeded");
            }



            Console.ReadLine();
        }
    }
}
