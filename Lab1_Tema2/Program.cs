using System;

namespace Lab_1___Ex_2
{
    /*Ex2
Scrieti un program care va calcula media aritmetica a trei numere citite de la
tastatura
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti primul numar:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar:");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al treilea numar:");
            int thirdNumber = int.Parse(Console.ReadLine());

            int mediaAritmetica = (firstNumber * secondNumber * thirdNumber) / 3;

            Console.WriteLine("Media Aritmetica a celor trei numere este: " + mediaAritmetica);
        }
    }
}
