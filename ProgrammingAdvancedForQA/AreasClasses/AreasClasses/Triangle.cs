using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasClasses
{
    internal class Triangle
    {
        public double TriangleBase { get; set; }
        public double height { get; set; }

        public double Area(double b, double h)
        {
            double area = 0.5 * b * h;
            return area;
        }
    }
}
