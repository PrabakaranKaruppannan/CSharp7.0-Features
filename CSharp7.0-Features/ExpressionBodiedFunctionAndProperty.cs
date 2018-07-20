using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7._0_Features
{
    class ExpressionBodiedFunctionAndProperty
    {
        static void Main(string[] args)
        {
            // Before C# 7.0, Expression body available only in method and Read only
            
            // In C# 7.0, Expression body available for constructor, 
            // (Get, Set) Property, Destructor

            Console.ReadLine();
        }
    }

    class Customer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        // Before C# 6.0, We use below way to get the full name
        public string GetFullNameUsingMethod()
        {
            return FirstName + LastName;
        }

        public string FullNameUsingReadOnlyProperty
        {
            get
            {
                return FirstName + LastName;
            }
        }

        // IN C# 6.0, you can write one line to return full name.
        public string FullNameUsingExpressionBodyProperty => FirstName + LastName;

        public string GetFullNameUsingExpressionBodyMethod() => FirstName + LastName;


        // Constructor
        public Customer()
        {
            FirstName = "Naveen";
        }

        // Descructor
        ~Customer()
        {
            FirstName = "Remove Naveen";
        }

        private string _fullName;
        public string FullName
        {
            get
            {
                return FirstName + LastName;
            }
            set
            {
                _fullName = FirstName + LastName;
            }
        }
    }
}
