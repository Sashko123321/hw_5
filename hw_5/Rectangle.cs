using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_5
{
    class Rectangle : Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override double GetArea()
        {
            return Width * Height;
        }
        public override double GetPerimeter()
        {
            return (Width + Height) *2;
        }

    }
}
