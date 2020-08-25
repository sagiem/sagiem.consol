using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace урок_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;

            Console.WriteLine("Введите значение");
            while(true)
            {

                if(int.TryParse(Console.ReadLine(), out result))

                    {

                    break;
                    }
                else
                {
                    Console.WriteLine("вы ввели неверное значение");
                }
                                   
            }

            try
            {
                //Console.WriteLine(10/result);

                throw new Myexample();
            }
            catch(Myexample ex)
            {
                Console.WriteLine(ex.Message);

            }

            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Упс...");
                Console.ReadLine();
            }
        }
    }
}
