using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._05._24
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point<int> point = new Point<int>();
            //point.X = 25;
            //point.Y = 5;
            //Point<uint> point2 = new Point<uint>(15u,20u);
            //Point<double> point3 = new Point<double>(3.35,6.8);
            //point.Print();
            //point2.Print();
            //point3.Print();
            Triangle<int> triangle = new Triangle<int>(1,2,3);
            Triangle<uint> triangle1 = new Triangle<uint>(5u,6u,7u);
            Triangle<double> triangle2 = new Triangle<double>(4.5,5.5,6.5);
            triangle.Print();
            triangle1.Print();
            triangle2.Print();
            Console.Read();
        }
    }
}
