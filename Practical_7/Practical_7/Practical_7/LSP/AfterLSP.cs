using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_7.LSP
{
    public abstract class Shape
    {
        public abstract int Area();
    }

    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override int Area()
        {
            return Width * Height;
        }
    }

    public class Square : Shape
    {
        public int SideLength { get; set; }

        public override int Area()
        {
            return SideLength * SideLength;
        }
    }

    internal class AfterLSP
    {

        public static void Main()
        {
            Rectangle shape = new Rectangle();
            shape.Width = 5;
            shape.Height = 10;
            Console.WriteLine(shape.Area()); // Output: 50

            Square shape2 = new Square();
            shape2.SideLength = 5;
            Console.WriteLine(shape2.Area()); // Output: 25
        }
    }
}
