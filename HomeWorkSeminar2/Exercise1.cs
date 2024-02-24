using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSeminar2
{
    internal class Exercise1
    {
        public void Execute()
        {
            Console.WriteLine("Задание 1, определение четности числа\nВведите целое число");
            while (true)
            {
                var input = Console.ReadLine();
                if (int.TryParse(input, out var result))
                {
                    Console.WriteLine("Введенное число " + (result % 2 == 0 ? "четное" : "не четное"));
                    break;
                }
                Console.WriteLine("Вы ввели не верное значение, попробуйте еще раз");
            }
        }
    }
}
