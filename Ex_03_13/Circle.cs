using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_13
{
    public class Circle
    {
        public static double PI = 3.14;
        int radius;

        public Circle(int pradius)
        {
            this.radius = pradius;
        }

        public double AreaCalculation()
        {
            return this.radius * this.radius * PI;
        }

        public static double AreaCalculation(int radius)
        {
            return radius * radius * PI;
        }
    }
}