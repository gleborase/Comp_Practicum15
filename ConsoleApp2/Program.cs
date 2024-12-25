using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{/// <summary>
/// Задача 4. Генерируются 10 случайных целых чисел в интервале (-40, 40). Вывести эти числа.
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
            for (int x = 0; x < 10; x++)
            { 
            int number=random.Next(-40,40);
                Console.WriteLine(number);  
            }
        }
    }
}
