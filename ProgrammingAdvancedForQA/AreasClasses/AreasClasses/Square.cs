using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasClasses
{
    public class Square
    {
        public double a {  get; set; }

        public double Area (double x)
        {
            double area = x * x;
            return area;
        }
    }
}
