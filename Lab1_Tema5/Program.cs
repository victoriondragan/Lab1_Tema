using System;

namespace Lab_1___Ex_5
{
    /*Ex 5
Se citesc doua numere de la tastatura, x,y. Scrieti un program care va afisa cele doua valori in ordine crescatoare.
• Exemplu: citim ,9,0 Afisam : 0 9 
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti primul numar: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar: ");
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
                Console.WriteLine("Primul numar este mai mare iar ordinea numerelor este: " + firstNumber + " ," + secondNumber);
            else if (firstNumber < secondNumber)
                Console.WriteLine("Al doilea numar este mai mare iar ordinea numerelor este: " + secondNumber + " ," + firstNumber);
            else
                Console.WriteLine("Numerele sunt egale.");
        }
    }
}
