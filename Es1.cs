using System;

namespace Es1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Dato un numero N in input, questo programma calcola i numeri compresi tra 1 e N");
            Console.WriteLine("Inserisci il numero");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("La sequenza finale:");
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}