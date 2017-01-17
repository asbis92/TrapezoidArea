using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proba
{
    class Program
    {
        static void Main(string[] args)
        {
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine(TrapezoidArea(b1, b2, h));

        }
        static double TrapezoidArea(double base1, double base2, double height)
        {
            double area = (base1 + base2) * height / 2;
            return area;
        }
    }
}
