using System;

namespace Lab_1___Ex_10
{
    /*Ex 10
Scrieti un program care sa va afisa suma cifrelor ununi numar intreg citit de la tastatura.
 Numarul are exact 2 cifre
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar format din doua cifre: ");
            int testNumber = int.Parse(Console.ReadLine());
            int modulusNumberDividedBy10 = testNumber % 10;
            int divisionBy10 = testNumber / 10;

            Console.WriteLine("Numarul este compus din urmatoarele cifre: {0} si {1}", divisionBy10, modulusNumberDividedBy10);
        }
    }
}
