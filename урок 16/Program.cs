using System;
using System.IO;
using System.Text;

namespace урок_16
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var sw= new StreamWriter("test.txt", true, Encoding.UTF8))
            {
                sw.Write("Привет ! ");
                sw.WriteLine("Привет !");

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
