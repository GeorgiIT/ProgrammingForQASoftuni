using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasClasses
{
    internal class Circle
    {
        public double r { get; set; }

        public double Area(double r)
        {
            double area = Math.PI * (r * r);
            return area;
        }
    }
}
