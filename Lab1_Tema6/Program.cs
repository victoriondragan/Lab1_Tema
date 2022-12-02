using System;

namespace Lab_1___Ex_6
{
    /*Ex6
Se citesc trei numere de la tastatura, x,y,z. Scrieti un program care va afisa cele trei valori in ordine
descrescatoare.
• Exemplu: citim 3,9,0 Afisam : 9 3 0
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti A - primul numar: ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti B - al doilea numar: ");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti C - al treilea numar: ");
            int C = int.Parse(Console.ReadLine());

            if (A > B && A > C)
            {
                if (B > C)
                    Console.WriteLine("Ordinea descrescatoare este: A: " + A + ", B: " + B + ", C: " + C);
                else
                    Console.WriteLine("Ordinea descrescatoare este: A: " + A + ", C: " + C + ", B: " + B);
            }

            else if (B > A && B > C)
            {
                if (A > C)
                    Console.WriteLine("Ordinea descrescatoare este: B: " + B + ", A: " + A + ", C: " + C);
                else
                    Console.WriteLine("Ordinea descrescatoare este: B: " + B + ", C: " + C + ", A: " + A);
            }

            else if (C > A && C > B)
            {
                if (A > B)
                    Console.WriteLine("Ordinea descrescatoare este: C: " + C + ", A: " + A + ", B: " + B);
                else
                    Console.WriteLine("Ordinea descrescatoare este: C: " + C + ", B: " + B + ", A: " + A);
            }
        }
    }
}
