using System;

namespace GitVS22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Hanoi(3, "A", "B", "C");
        }
        static void Hanoi(int n, string from, string to, string via)
        {
            if (n == 1)
            {
                Console.WriteLine($"spost un disco da {from} a {to}.");
            }
            else
            {
                Hanoi(n - 1, from, via, to);
                Hanoi(1, from, to, via);
                Hanoi(n - 1, via, to, from);
            }
        }
    }
}
