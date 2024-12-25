using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{/// <summary>
 /// Задача 6. Генерируется 12 случайных целых чисел в интервале (-50,50). Вывести эти числа и сообщения: отрицательное-положительное.
 /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Func();
            Console.Read();
        }
        static void Func()
        {
            Random random = new Random();
            for (int x = 0; x < 12; x++)
            {
                int number = random.Next(-50,50);
                if (number > 0) Console.WriteLine($"{number} - положительное число");
                if (number < 0) Console.WriteLine($"{number} - отрицательное число");
                if (number == 0) Console.WriteLine($"{number} - равно нулю");
            }
        }
    }
}
