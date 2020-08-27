using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Урок_17
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //Thread thread = new Thread(new ThreadStart(DoWork));
            //thread.Start();

            //Thread thread2 = new Thread(new ParameterizedThreadStart(DoWork2));
            //thread2.Start(1000);


            //int j = 0;
            //for (int i = 0; i < int.MaxValue; i++)
            //{
            //    j++;

            //    if (j % 10000 == 0)
            //    {
            //        Console.WriteLine("Main");
            //    }
            //}
            #endregion

            //DoWorkAsync();

            Thread thread = new Thread(new ThreadStart(DoWork));
            thread.Priority = ThreadPriority.Highest;
            thread.Start();

      

            Console.ReadLine();
        }

        static async Task DoWorkAsync()
        {
            await Task.Run(() => DoWork());
            Console.WriteLine("Do Work Async");
        }

        static void DoWork()
        {
            int j = 0;
            for(int i = 0; i < 10000; i++)
            {
                Console.WriteLine(j/100*10-5);
                j++;
            }
        }

        

    }
}
