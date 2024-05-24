using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._05._24
{
    class Segment <A>
    {
        private List<List<A>> segments;

        public Segment() 
        {

        }
        public Segment(List<List<A>> segments) 
        {
            this.segments = segments;
        }

        public List<List<A>> Segments { get => segments; set => segments = value; }

        public double Lenght()
        {
            dynamic x1 = segments[0][0];
            dynamic x2 = segments[1][0];
            dynamic y1 = segments[0][1];
            dynamic y2 = segments[1][1];
            double l = Math.Sqrt(Math.Pow((double)x1 - (double)x2, 2) + Math.Pow((double)y1 - (double)y2, 2));
            return l;
        }
        public void Print()
        {
            Console.WriteLine($"Координаты точек: {segments[0][0]},{segments[0][1]};{segments[1][0]},{segments[1][1]}\nДлина: {Lenght()}");
        }
    }
}
