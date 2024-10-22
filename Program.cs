using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewC_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isWork = true;
            int userInput;

            while (isWork)
            {
                Console.WriteLine($"Выберите пункт меню:" +
                    $"1. Сложить два числа." +
                    $"2. Умножить два числа." +
                    $"3. Показать рандомное число." +
                    $"4. Очистить консоль." +
                    $"5. Выход.");

               userInput = Convert.ToInt32( Console.ReadLine());

                if (userInput == 1)
                {

                }
                else if (userInput == 2)
                {
                    
                }
                else if (userInput == 3)
                {

                }
                else if (userInput == 4)
                {

                }
                else if (userInput == 5)
                {

                }


                Console.WriteLine();
            }

        }
    }
}
