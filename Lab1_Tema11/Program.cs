using System;

namespace Lab_1___Ex_11
{
    /*Ex 11
Folosind instructiunea “switch”, scrieti un program care citind de la tastatura un numar intreg va verifica urmatoarele
“unu” daca numarul citit este 1
“doi” daca numarul citit este 2
“trei” daca numarul citit este 3
“cinci” daca numarul citit este 5
“opt” daca numarul citit este 8
“neidentificat” pentru orice alt caz
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar:");
            int testNumber = int.Parse(Console.ReadLine());

            switch (testNumber)
            {
                case 1:
                    if (testNumber == 1)
                        Console.WriteLine("unu");
                    break;
                case 2:
                    if (testNumber == 2)
                        Console.WriteLine("doi");
                    break;
                case 3:
                    if (testNumber == 3)
                        Console.WriteLine("trei");
                    break;
                case 4:
                    if (testNumber == 5)
                        Console.WriteLine("cinci");
                    break;
                case 5:
                    if (testNumber == 8)
                        Console.WriteLine("opt");
                    break;
                default:
                    Console.WriteLine("neidentificat");
                    break;
            }
        }
    }
}
