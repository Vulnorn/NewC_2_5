using System;

namespace NewC_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isWork = true;
            string userInput;
            string consoleMenuSummNumbers = "1";
            string consoleMenuTimesNumbers = "2";
            string consoleMenuRandomNumber = "3";
            string consoleMenuClaerConsole = "4";
            string consoleMenuExite = "5";

            while (isWork)
            {
                Console.WriteLine($"Выберите пункт меню:\n" +
                    $"{consoleMenuSummNumbers}. Сложить два числа.\n" +
                    $"{consoleMenuTimesNumbers}. Умножить два числа.\n" +
                    $"{consoleMenuRandomNumber}. Показать рандомное число.\n" +
                    $"{consoleMenuClaerConsole}. Очистить консоль.\n" +
                    $"{consoleMenuExite}. Выход.\n");

                userInput = Console.ReadLine();

                if (userInput == consoleMenuSummNumbers)
                {
                    Console.WriteLine($"Vvedite pervoe chislo");

                    userInput = Console.ReadLine();
                    int ferstNumber = Convert.ToInt32(userInput);

                    Console.WriteLine($"Vvedite vtoroe chislo");

                    userInput = Console.ReadLine();
                    int secondNumber = Convert.ToInt32(userInput);
                    int summaNumbers = ferstNumber + secondNumber;

                    Console.WriteLine($"Cymma chisel - {summaNumbers}");
                }
                else if (userInput == consoleMenuTimesNumbers)
                {
                    Console.WriteLine($"Vvedite pervoe chislo");

                    userInput = Console.ReadLine();
                    int ferstNumber = Convert.ToInt32(userInput);

                    Console.WriteLine($"Vvedite vtoroe chislo");

                    userInput = Console.ReadLine();
                    int secondNumber = Convert.ToInt32(userInput);
                    int summaNumbers = ferstNumber * secondNumber;

                    Console.WriteLine($"Proizvedenie chisel - {summaNumbers}");
                }
                else if (userInput == consoleMenuRandomNumber)
                {
                    Random random = new Random();

                    int randomNumber = random.Next();

                    Console.WriteLine($"Slychainoe chislo - {randomNumber}");
                }
                else if (userInput == consoleMenuClaerConsole)
                {
                    Console.Clear();
                }
                else if (userInput == consoleMenuExite)
                {
                    isWork = false;
                }
            }
        }
    }
}