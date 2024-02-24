namespace HomeWorkSeminar2
{
    internal class Exercise2
    {
        public void Execute()
        {
            Console.WriteLine("Задание 2, подсчёт суммы карт\nВведите натуральное число карт");
            while (true)
            {
                var input = Console.ReadLine();
                if (int.TryParse(input, out var cardNumer) && cardNumer > 0)
                {
                    int sum = 0;
                    Console.WriteLine("Введите значения карт от 2 до 10, а так же J, Q, K, A через Enter");
                    for (int i = 0; i < cardNumer; i++)
                    {
                        input = Console.ReadLine();
                        input = input.ToUpper();
                        if (int.TryParse(input, out int card) && card >= 2 && card <= 10)
                            sum += card;
                        else if (input == "J" || input == "Q" || input == "K" || input == "A")
                            sum += 10;
                        else
                        {
                            Console.WriteLine("Вы ввели неверное значение карты, введите еще раз");
                            i--;
                        }
                    }
                    Console.WriteLine("Сумма карт: " + sum.ToString());
                    break;
                }
                Console.WriteLine("Вы ввели не верное значение, попробуйте еще раз");
            }
        }
    }
}
