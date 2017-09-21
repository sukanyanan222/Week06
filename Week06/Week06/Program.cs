using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week06
{
    class Program
    {
        static void EvenOddNumber(double A)
        {
            string x;
            if ((A % 2) > 0)
            {
                x = ("This is Odd Number");
            }
            else
            {
                x = ("This is Even Number");
            }
            Console.WriteLine("{0}", x);
            return;
        }
        static void Main(string[] args)
        {
            double A;
            Console.Write("Enter a number : ");
            A = double.Parse(Console.ReadLine());
            EvenOddNumber(A);
            Console.ReadLine();
        }   
    }
}
