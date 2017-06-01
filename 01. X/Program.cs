using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.X
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

             

            var row = (n - 1) / 2;
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine("{0}x{1}x{0}", new string(' ', i), new string(' ', (n - 2) - 2 * i));
            }
            Console.WriteLine("{0}x{0}", new string(' ', row));
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine("{0}x{1}x", new string(' ', n - row - 2 - i), new string(' ', i * 2+1));
            }
        }

    }
    }

