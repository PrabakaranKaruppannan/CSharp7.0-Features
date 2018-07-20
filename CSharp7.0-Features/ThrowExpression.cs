using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7._0_Features
{
    class ThrowExpression
    {
        static void Main(string[] args)
        {
            Person person = new Person("test");
            Console.WriteLine(person.GetFirstName());

            Console.Read();
        }
    }

    class Person
    {
        public string Name { get; }

        public Person(string name) => Name = name ?? throw new ArgumentNullException(nameof(name));

        public string GetFirstName()
        {
            var parts = Name.Split(' ');

            //In C# 6.0
            if (parts.Length < 0)
            {
                throw new InvalidOperationException("No name!");
            }

            //In C# 7.0
            return parts.Length > 0 ? parts[0] : throw new InvalidOperationException("No name!");
        }

        public string GetLastName() => throw new NotImplementedException();
    }
}
