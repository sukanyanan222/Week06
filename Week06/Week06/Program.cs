using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week06
{
    class Program
    {
        static void Moon(double S)
        {
            double Z;
            Z = (S * 1.6);
            Console.WriteLine("Weight on the moon is : {0} N.", Z);
        }
        static void Main(string[] args)
        {
            double S;
            Console.Write("Enter the Mass : ");
            S = double.Parse(Console.ReadLine());
            Moon(S);
            Console.ReadLine();
        }
    }
}
