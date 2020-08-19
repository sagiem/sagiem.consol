using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace урок_11
{
    class Program
    {
        static void Main(string[] args)
        {
            var point1 = new Point(2, 5);
            var point2 = new Point(7, 3);

            var sumPoint = point1 == point2;

            Console.WriteLine($"{sumPoint}");

            Console.ReadKey();
        }
        

    }
}
