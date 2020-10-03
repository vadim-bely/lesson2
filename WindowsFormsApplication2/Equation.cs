using System;

namespace WindowsFormsApplication2
{
    public class Equation
    {
        private double a;
        private double b;
        private double c;
        private double D;
        
        public double getX1()
        {
            return (-b + Math.Sqrt(D)) / (2 * a);
        }
        
        public double getX2()
        {
            return (-b - Math.Sqrt(D)) / (2 * a);
        }


        public Equation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            
            D = Math.Pow(c, 2) - 4 * a * c;
        }
        
        
    }
}