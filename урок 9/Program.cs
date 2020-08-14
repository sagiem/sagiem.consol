using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace урок_9
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        //static int Fibonachi(int n)
        //{
        //    if (n == 0 || n == 1)
        //    {
        //        return n;
        //    }
        //    else
        //    {
        //        return Fibonachi(n - 1) + Fibonachi(n - 2);
        //    }
        //}

        static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            int tmp;

            for (int i = 0; i < n; i++)
            {
                tmp = a;
                a = b;
                b += tmp;
            }

            return a;
        }
    }
}
