using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    // wprowadzamy liczbę
    // program sprawdza czy parzysta czy też nie
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Proszę podaj liczbę");
            int number = GetNumber();
            string evenNumberOrOddNumber = (number % 2 == 0) ? "parzysta" : "nieparzysta";

            Console.WriteLine($"Wpisana liczba: {number} jest {evenNumberOrOddNumber}");

        }

        static int GetNumber()
        {
            while(true)
            { 
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int number))
                {
                    string message = $"wpisanych znaków {input} nie można przekonwertować na liczbę, spróbuj ponownie";
                    Console.WriteLine(message);
                }
                else
                {
                    return number;
                }
            }
        }
    }
}
