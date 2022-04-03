using System;
using System.Collections.Generic;
using System.Linq;

namespace GitVS22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int n = 5;
            Hanoi(3,
                new Rod("A", new Stack<int>(Enumerable.Range(1, n).Reverse())),
                new Rod("B", new Stack<int>()),
                new Rod("C", new Stack<int>())
                );
        }
        static void Hanoi(int n, Rod from, Rod to, Rod via)
        {
            if (n == 1)
            {
                int d = from.Pop();
                to.Push(d);
                Console.WriteLine($"Sposta il disco {d} da {from.Label} a {to.Label}.");
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
