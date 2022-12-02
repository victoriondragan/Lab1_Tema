using System;

namespace Lab_1___Ex_9
{
    /*Ex 9
Scrieti un program care interschimba valoarea a doua variabile intregi.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul x:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul y:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Numerele inainte de interschimbare sunt: x = {0} si y = {1}", x, y);

            int mediumZ = 0;

            mediumZ = y;
            y = x;
            x = mediumZ;

            Console.WriteLine("Numerele dupa interschimbare sunt: x = {0} si y = {1}", x, y);
        }
    }
}
