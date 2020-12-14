using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear(); 

            string f;

            Console.ForegroundColor = ConsoleColor.Black;

            Console.Write("Введите символ: ");

            f = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Введен символ: " + f);
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Write("Введите значение целого числа: ");

            int a = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Введено значение целого числа: " + a);
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Write("Введите значение вещественного числа: ");

            double b = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Введено значение вещественного числа: " + "{0:#.###}", b);
        }
    }
}
