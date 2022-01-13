using System;

namespace MyLib
{
    public class Figure
    {
        public double GetSquare(double r)
        {
            return 3.14 * r * r;
        }
        public double GetSquare(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
    }
}
