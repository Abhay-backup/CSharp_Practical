using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_7.LSP
{


    public class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public virtual int Area()
        {
            return Width * Height;
        }
    }

    public class Square : Rectangle
    {
        public override int Area()
        {
            return Width * Width;
        }
        public static void Main()
        {
            Square sqr = new Square();
            sqr.Width = 5;
            Console.WriteLine(sqr.Area()); // Output: 25
        }
    }
}



