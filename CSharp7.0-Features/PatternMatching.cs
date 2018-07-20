using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7._0_Features
{
    class PatternMatching
    {
        static void Main(string[] args)
        {
            List<Object> shapes = new List<Object>();
            shapes.Add(new Shape());
            shapes.Add(new Square());
            shapes.Add(new Rectangle());

            // In C# 6.0
            foreach (var shape in shapes)
            {
                if (shape is Shape)
                {
                    var x = (Shape) shape;
                    Console.WriteLine(x.Name);
                }
                else if (shape is Square)
                {
                    var x = (Square)shape;
                    Console.WriteLine(x.Name);
                }
                else if (shape is Rectangle)
                {
                    var x = (Rectangle)shape;
                    Console.WriteLine(x.Name);
                }
            }

            // In C# 7.0
            foreach (var shape in shapes)
            {
                if (shape is Shape s)
                {
                    Console.WriteLine(s.Name);
                }
                else if (shape is Square sq)
                {
                    Console.WriteLine(sq.Name);
                }
                else if (shape is Rectangle rec)
                {
                    Console.WriteLine(rec.Name);
                }
            }
            Console.Read();
        }
    }

    class Shape
    {
        public virtual string Name { get; set; } = "Base Shape";
    }

    class Square : Shape
    {
        public override string Name { get; set; } = "Square";
    }

    class Rectangle : Shape
    {
        public override string Name { get; set; } = "Rectangle";
    }
}
