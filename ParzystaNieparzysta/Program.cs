using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParzystaNieparzysta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w programie gdzie sprawdzimy czy liczba jest parzysta lub nie");

            while (true)
            {

                var number = DataCheck();
                if (number % 2 == 0)
                {
                    Console.WriteLine("Twoja liczba jest parzysta");
                }
                else
                {
                    Console.WriteLine("Twoja liczba jest nieparzysta");
                }

                if (ExitMenu())
                    break;

            }
            Console.ReadLine();
        }

        private static int DataCheck()
        {
            while (true)
            {
                Console.WriteLine("Proszę podać liczbę :");
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Podano nie prawidłową wartoś\n Sprobuj ponownie");
                    continue;
                }

                return number;
            }
        }

        private static bool ExitMenu()
        {
            while (true)
            {
                Console.WriteLine("Aby zakonczyc nacisniej X, aby kontynuowac C");
                var choose = Console.ReadLine().ToUpper();

                if (choose.Equals("X"))
                    return true;

                if (choose.Equals("C"))
                    return false;
            }
        }

    }
}
