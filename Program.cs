using System;

namespace NewC_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isWork = true;
            int userInput;
            int consoleMenu1 = 1;
            int consoleMenu2 = 2;
            int consoleMenu3 = 3;
            int consoleMenu4 = 4;
            int consoleMenu5 = 5;

            while (isWork)
            {
                Console.WriteLine($"Выберите пункт меню:\n" +
                    $"1. Сложить два числа.\n" +
                    $"2. Умножить два числа.\n" +
                    $"3. Показать рандомное число.\n" +
                    $"4. Очистить консоль.\n" +
                    $"5. Выход.\n");

                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == consoleMenu1)
                {
                    Console.WriteLine($"Vvedite pervoe chislo");

                    userInput = Convert.ToInt32(Console.ReadLine());
                    int ferstNumber = userInput;

                    Console.WriteLine($"Vvedite vtoroe chislo");

                    userInput = Convert.ToInt32(Console.ReadLine());
                    int secondNumber = userInput;
                    int summaNumbers = ferstNumber + secondNumber;

                    Console.WriteLine($"Cymma chisel - {summaNumbers}");
                }
                else if (userInput == consoleMenu2)
                {
                    Console.WriteLine($"Vvedite pervoe chislo");

                    userInput = Convert.ToInt32(Console.ReadLine());
                    int ferstNumber = userInput;

                    Console.WriteLine($"Vvedite vtoroe chislo");

                    userInput = Convert.ToInt32(Console.ReadLine());
                    int secondNumber = userInput;
                    int summaNumbers = ferstNumber * secondNumber;

                    Console.WriteLine($"Proizvedenie chisel - {summaNumbers}");
                }
                else if (userInput == consoleMenu3)
                {
                    Random random = new Random();

                    int randomNumber = random.Next();

                    Console.WriteLine($"Slychainoe chislo - {randomNumber}");
                }
                else if (userInput == consoleMenu4)
                {
                    Console.Clear();
                }
                else if (userInput == consoleMenu5)
                {
                    isWork = false;
                }
            }
        }
    }
}