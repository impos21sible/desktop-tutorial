using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A1,A2,B1,B2,C1,C2;
            Console.Write("Введите A = ");
             A1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите B1 = ");
             B1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите C1 = ");
             C1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите A2 = ");
            A2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите B2 = ");
             B2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите C2 = ");
             C2 = Convert.ToInt32(Console.ReadLine());

            double D = (1*A1*B2-A2*B1);
            Console.WriteLine($"D={D}");

            double x = (C1*B2 - C2*B1)/D;
            Console.WriteLine($"x={x}");

            double y = (A1*C2 - A2*C1)/D;

            Console.WriteLine($"y={y}");

            double РешениеС1 = (A1*x+B1*y);
            double РешениеС2 = (A2*x+B2*y);
            Console.WriteLine($"Провека числа С1 ={РешениеС1}");
            Console.WriteLine($"Провека числа С2 ={РешениеС2}");

        }
    }
}
