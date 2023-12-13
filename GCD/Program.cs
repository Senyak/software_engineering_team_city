using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD
{
    internal class Program
    {
        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                var t = b;
                b = a % b;
                a = t;
            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Алгоритм Евклида");
            //IM GONNA RUIN THIS PROJECT
            Console.WriteLine("Наибольший общий делитель чисел {0} и {1} равен {2}", 294, 162, GCD(294, 162));
            Console.ReadLine();
        }
    }
}
