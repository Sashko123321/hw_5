﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_5
{
    class Circle : Figure
    {
        public double Radius { get;set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
