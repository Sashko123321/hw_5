using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_5
{
    class Triangle :Figure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

        }
        public override double GetArea()
        {
            return Math.Sqrt(GetPerimeter() / 2 * (GetPerimeter() / 2 - SideA) * (GetPerimeter() / 2 - SideB) * (GetPerimeter() / 2 - SideC));
        }
        public override double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }
    }
}
