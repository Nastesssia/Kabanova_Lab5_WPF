﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kabanova_Lab5_WPF
{
    public class Square : IRoot
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public string Result;

        public Square(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public string PrintResult()
        {
            return $"Корень(ни) квадратного уравнения = {Roots()}";
        }

        public string Roots()
        {
            double D = B * B - 4 * A * C;
            if (D == 0) return (-B / 2 * A).ToString();
            else if (D > 0)
            {
                double x1 = (-B + Math.Sqrt(D)) / 2 * A;
                double x2 = (-B - Math.Sqrt(D)) / 2 * A;
                return $"x1={x1:F2} x2={x2:F2}";
            };
            return "Корней нет";
        }
    }
}
