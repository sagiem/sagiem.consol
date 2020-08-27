using System;
using System.IO;
using System.Text;

namespace урок_16
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            string city;

            Console.WriteLine("Введите ваше имя");
            name = Console.ReadLine();

            Console.WriteLine("Введите ваш возраст");
            while(true)
            {
                if(int.TryParse(Console.ReadLine(), out int result))
                {
                    if (result < 0 || result > 150)
                    {
                        Console.WriteLine("Вы ввели неверный возраст");
                    }

                    else
                    {
                        age = result;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели неверный возраст");
                }
            }
            Console.WriteLine("Введите город проживания");

            city = Console.ReadLine();



            using (var sw= new StreamWriter("test.txt", true, Encoding.UTF8))
            {
                sw.WriteLine($"Привет ! Ваше имя {name} Ваш возраст {age} Вы из города {city}");
                

            }

            using(var sr=new StreamReader("test.txt"))
            {
                var text = sr.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.ReadLine();
        }
    }
}
