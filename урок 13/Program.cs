using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace урок_13
{
    class Program
    {
       
        static void Main(string[] args)
        {
            var car = new Car();
            car.cool = 10;
            Console.WriteLine(car.to(10,2));
            Console.WriteLine(car.Move(5));
            Console.ReadLine();

            
        }

    }
}
