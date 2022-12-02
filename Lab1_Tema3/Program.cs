using System;

namespace Lab1___Ex3
{
    /*Ex3
Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la
tastaura
    */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar intreg: ");
            int userNumber = int.Parse(Console.ReadLine());

            int lastDigit = userNumber % 10;

            Console.WriteLine("Ultima cifra a numarului este: " + lastDigit);

        }
    }
}
