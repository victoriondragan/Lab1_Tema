using System;

namespace Lab_1___Ex_8
{
    /*Ex 8
Se citesc doua numere de la tastatura, x si y. Scrieti un program care va verifica
daca x este divizibil cu y.
 In cazul in care x este divizibil cu y, programul va afisa “divizibil” iar in caz contrar,
“indivizibil”.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti x:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti y:");
            int y = int.Parse(Console.ReadLine());
            int testNumber = x % y;

            if (testNumber == 0)
            {
                Console.WriteLine("divizibil");
            }
            else
                Console.WriteLine("indivizibil");
        }
    }
}
