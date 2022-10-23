using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите A=");
            double A = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите B=");
            double B = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите C=");
            double C = Convert.ToInt32(Console.ReadLine());
            double D = Pow(B, 2.0) - 4 * A * C;
            
            Console.WriteLine($"D={D}");

            double x1 = (-B + Sqrt(D))/(2.0*A);
            double x2 = (-B - Sqrt(D))/(2.0*A);

            if (x2<x1) 
            {
                Console.WriteLine($"x2={x2}");
                Console.WriteLine($"x1={x1}");
            }

            else
            {
                Console.WriteLine($"x1={x1}");
                Console.WriteLine($"x2={x2}");
            }
            
            









        }
    }
}
