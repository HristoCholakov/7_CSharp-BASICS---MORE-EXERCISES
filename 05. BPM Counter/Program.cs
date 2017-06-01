using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            double bars = Math.Round(b / 4.0, 1);
            double beats = (60 / a) * b;
            Console.WriteLine($"{bars}bars - {beats}");
        }
    }
}
