using System;

namespace Lab_1___Ex_7
{
    /*Ex7
Scrieti un program care va verifica daca un numar citit de la tastatura este par sau
impar
 In cazul in care numarul este par, programul va afisa “par” iar in caz contrar, “impar”.
 Google :even and odd number
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar intreg diferit de zero: ");
            int testNumber = int.Parse(Console.ReadLine());
            int modulusCheck = testNumber % 2;

            if (modulusCheck == 0)
            {
                Console.WriteLine("Numarul {0} este par", testNumber);
            }
            else
                Console.WriteLine("Numarul {0} este impar", testNumber);
        }
    }
}
