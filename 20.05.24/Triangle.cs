using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._05._24
{
    class Triangle <P>
    {
        private P a;
        private P b;
        private P c;

        public Triangle() { }
        public Triangle( P a, P b, P c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public P A { get { return a; } set {a = value;} }
        public P B { get { return b; } set { b = value; } }
        public P C { get { return c; } set { c = value; } }

        public void Print()
        {
            if (Examination() == true)
            {
                Console.WriteLine($"Стороны треугольника: {a}, {b}, {c}");
                Area();
            }
            else
            {
                Console.WriteLine("Треугольник не существует");
            }
        }
        public bool Examination()
        {
            dynamic a1 = A;
            dynamic b1 = B;
            dynamic c1 = C;
            bool examination=true;
            if (a1 < b1 + c1)
            {
                if (b1 < a1 + c1)
                {
                    if (c1 < a1 + b1)
                    {
                        examination = true;
                    }
                    else
                    {
                        examination = false;
                    }
                }
                else
                {
                    examination = false;
                }
            }
            else
            {
                examination=false;
            }
            return examination;
        }
        public void Area()
        {
            dynamic a1 = A;
            dynamic b1 = B;
            dynamic c1 = C;
            double p = (double)(a1 + b1 + c1) / 2;
            Console.WriteLine($"Площадь:{Math.Sqrt(p * (p - a1) * (p - b1) * (p - c1))}");
        }
    }
}
