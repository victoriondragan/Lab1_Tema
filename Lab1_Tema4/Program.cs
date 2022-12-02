using System;

namespace Lab_1___Ex_4
{
    /*Ex 4
Scrieti un program care va afisa semnul unui numar citit de la tastatura
• Daca numarul este pozitiv, va afisa “+”
• Daca numarul este negativ, va afisa “-”
• Daca numarul este 0, va afisa “0”
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar intreg: ");
            int integerNumber = int.Parse(Console.ReadLine());

            if (integerNumber > 0)
                Console.WriteLine("+ __ Numarul este pozitiv");
            else if (integerNumber < 0)
                Console.WriteLine("- __ Numarul este negativ");
            else
                Console.WriteLine("Numarul este zero.");
        }
    }
}
