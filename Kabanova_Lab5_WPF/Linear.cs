using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kabanova_Lab5_WPF
{
    public class Linear : IRoot
    {
        public double A { get; set; }
        public double B { get; set; }
        public string Result2;


        public Linear(double a, double b)
        {
            A = a;
            B = b;
        }

         string IRoot.PrintResult()
         {
            return Result2;
         }

        void IRoot.Roots()
        {
            Result2 = (-B / A).ToString();
        }
    }
}
