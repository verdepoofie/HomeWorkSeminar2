namespace HomeWorkSeminar2
{
    internal class Exercise3
    {
        public void Execute()
        {
            Console.WriteLine("Задание 3, gроверка простого числа\nВведите натуральное число");
            while (true)
            {
                var input = Console.ReadLine();
                if (int.TryParse(input, out var result) && result > 0)
                {
                    bool isNotPrimal = false;
                    for (int i = 2; i < result; i++)//i = 2, так как все числа делятся на 1 без остатка
                        if (result % i == 0)
                        {
                            isNotPrimal = true;
                            break;
                        }
                    Console.WriteLine("Введенное число " + (isNotPrimal ? "не простое" : "простое"));
                    break;
                }
                Console.WriteLine("Вы ввели не верное значение, попробуйте еще раз");
            }
        }
    }
}
