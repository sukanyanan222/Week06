using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week06
{
    class Program
    {
        static void trapezoid(double E, double F, double G)
        {
            double H;
            H = (0.5 * (E + F) * G);
            Console.Write("Area of the trapezoid is : {0}", H);
        }
        static void Main(string[] args)
        {
            double E, F, G;
            Console.Write("Enter the Parallel 1 :");
            E = double.Parse(Console.ReadLine());
            Console.Write("Enter the Parallel 2 :");
            F = double.Parse(Console.ReadLine());
            Console.Write("Enter High :");
            G = double.Parse(Console.ReadLine());
            trapezoid(E, F, G);
            Console.ReadLine();
        }
    }
}
