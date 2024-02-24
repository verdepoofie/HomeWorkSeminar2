using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSeminar2
{
    internal class Exercise5
    {
        public void Execute()
        {
            Console.WriteLine("Задание 5, игра «Угадай число»\nВведите натуральное максимальное число диапазона");
            while (true)
            {
                var input = Console.ReadLine();
                if (int.TryParse(input, out var maxValue) && maxValue > 0)
                {
                    int correctAnswer = (new Random()).Next(maxValue);
                    Console.WriteLine("Вводите свои догадки, введите q, чтобы завершить игру");
                    while (true)
                    {
                        input = Console.ReadLine();
                        if(int.TryParse(input, out int guess))
                        {
                            if (guess > correctAnswer)
                                Console.WriteLine("Введенное значение больше");
                            if (guess < correctAnswer)
                                Console.WriteLine("Введенное значение меньше");
                            if(guess == correctAnswer)
                            {
                                Console.WriteLine("Вы угадали!");
                                break;
                            }
                        }
                        else if(input == "q")
                        {
                            Console.WriteLine("Загаданное число: " +  correctAnswer.ToString());
                            break;
                        }
                        else
                            Console.WriteLine("Вы ввели не верное значение, попробуйте еще раз");
                    }
                    break;
                }
                Console.WriteLine("Вы ввели не верное значение, попробуйте еще раз");
            }
        }
    }
}
