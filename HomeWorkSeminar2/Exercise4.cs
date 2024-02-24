using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSeminar2
{
    internal class Exercise4
    {
        public void Execute()
        {
            Console.WriteLine("Задание 4, наименьший элемент в последовательности\nВведите натуральное число длины последоватеьлности");
            while (true)
            {
                var input = Console.ReadLine();
                if (int.TryParse(input, out var arrayLength) && arrayLength > 0)
                {
                    int min = int.MaxValue;
                    Console.WriteLine("Введите целочисленные значения чисел последовательноси через Enter");
                    for (int i = 0; i < arrayLength; i++)
                    {
                        input = Console.ReadLine();
                        if (int.TryParse(input, out int number))
                        {
                            if(number < min)
                                min = number;
                        }
                        else
                        {
                            Console.WriteLine("Вы ввели неверное значение, введите еще раз");
                            i--;
                        }
                    }
                    Console.WriteLine("Наименьшее число: " + min.ToString());
                    break;
                }
                Console.WriteLine("Вы ввели не верное значение, попробуйте еще раз");
            }
        }
    }
}
