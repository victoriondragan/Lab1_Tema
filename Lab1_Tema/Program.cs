using System;

namespace Lab_1___Ex_1
{
    /*Ex1
Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui
paralelipiped dreptunghic, va afisa volumul lui
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Specificati lungimea Paralelipipedului.");
            int lungimea = int.Parse(Console.ReadLine());

            Console.WriteLine("Specificati latimea Paralelipipedului");
            int latimea = int.Parse(Console.ReadLine());

            Console.WriteLine("Specificati inaltimea Paralelipipedului");
            int inaltimea = int.Parse(Console.ReadLine());

            int volumulParalelipipedului = lungimea * latimea * inaltimea;

            Console.WriteLine("Volumul Paralelipipedului este " + volumulParalelipipedului);
        }
    }
}
