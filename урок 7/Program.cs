using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace урок_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];
            int sumArray=0;
            int razArray;
            int pArray=1;

            for(int i=0;i<15;)
            {
                int n = 15 - i;
                Console.WriteLine("Введите значение.Осталось элементов "+n);
                if(int.TryParse(Console.ReadLine(), out int result))
                {
                    array[i] = result;
                    i++;
                }
                else
                {
                    Console.WriteLine("Вы ввели неверное значение");
                }
         
            }

            for (int i = 0; i < array.Count(); i++)
            {
                
                sumArray += array[i];
            }

            razArray = array[0];
            var t = 1;
            while(t < array.Count())
            {
                razArray -= array[t];
                t++;
            }

            var m = 0;

            do
            {
                pArray *= array[m];
                m++;
            }
            while (m < 15);


            Console.WriteLine("Сумма элементов массива равна {0} Разность {1} Произведение {2}", sumArray, razArray, pArray);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
