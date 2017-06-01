using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photoNum = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int mounth = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            decimal bytes = decimal.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string orientation = "";
            string sizeName = "B";
            if (bytes > 1000)
            {
                bytes /= 1000;
                sizeName = "KB";
            }

            if (bytes > 1000)
            {
                bytes /= 1000;
                sizeName = "MB";
            }

            if (width > height)
            {
                orientation = "landscape";
            }
            else if (height > width)
            {
                orientation = "portrait";
            }
            else
            {
                orientation = "square";
            }
            Console.WriteLine($"Name: DSC_{photoNum:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:D2}/{mounth:D2}/{year:D2} {hours:D2}:{minutes:D2}");
            Console.WriteLine($"Size: {bytes}{sizeName}");
            Console.Write($"Resolution: {width}x{height} ");
            Console.WriteLine($"({orientation})");


        }
    }
}
