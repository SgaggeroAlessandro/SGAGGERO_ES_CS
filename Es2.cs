using System;
namespace Es2
{
    class Program
    {
        static void Main(string[] args)
        {
            int d, n, tr, nc;
            tr = 3;
            bool ni;
            bool n2i;
            Random rnd = new Random();
            Console.WriteLine("Data una difficoltà iniziale, questo programma dice se il numero inserito dall'utente è più grande o più piccolo rispetto a uno casuale scelto dal programma");
            Console.WriteLine("Seleziona la difficoltà:");
            Console.WriteLine("1 = facile");
            Console.WriteLine("2 = media");
            Console.WriteLine("3 = difficile");
            do
            {
                string di = Console.ReadLine();
                ni = int.TryParse(di, out d);
                if (!ni || d < 1 || d > 3) 
                {
                    Console.WriteLine("Seleziona una difficoltà valida, tra 1, 2 o 3");
                }
            } while (!ni || d < 1 || d > 3);
            if (d == 1)
            {
                nc = rnd.Next(1, 6);
                Console.WriteLine("E' stata scelta la difficoltà facile");
                while(tr > 0)
                {
                    tr--;
                    Console.WriteLine("Inserisci un numero compreso tra 1 e 5");
                    string ns = Console.ReadLine();
                    n2i = int.TryParse(ns, out n);
                    while(!n2i || n > 5 || n < 1)
                    {
                        Console.WriteLine("Seleziona un numero valido");
                         ns = Console.ReadLine();
                        n2i = int.TryParse(ns, out n);
                    }
                    if(n > nc)
                    {
                        Console.WriteLine("Il numero inserito è troppo grande");
                        
                        
                    }else if(n < nc)
                    {
                        Console.WriteLine("Il numero inserito è troppo piccolo");
                        
                    }
                    else
                    {
                        Console.WriteLine("Hai indovinato. Il numero era: " + nc);
                        return;
                    }
                    if (tr > 0)
                    {
                        Console.WriteLine("Hai ancora " + tr + " tentativi rimasti");
                    }

                }
                Console.WriteLine("Game over, hai perso. Il numero era: " + nc);
            }
            else if(d == 2)
            {
                nc = rnd.Next(1, 11);
                Console.WriteLine("E' stata scelta la difficoltà media");
                while (tr > 0)
                {
                    tr--;
                    Console.WriteLine("Inserisci un numero compreso tra 1 e 10");
                    string ns = Console.ReadLine();
                    n2i = int.TryParse(ns, out n);
                    while (!n2i || n > 10 || n < 1)
                    {
                        Console.WriteLine("Seleziona un numero valido");
                        ns = Console.ReadLine();
                        n2i = int.TryParse(ns, out n);
                    }
                    if (n > nc)
                    {
                        Console.WriteLine("Il numero inserito è troppo grande");
                        ;

                    }
                    else if (n < nc)
                    {
                        Console.WriteLine("Il numero inserito è troppo piccolo");
                        
                    }
                    else
                    {
                        Console.WriteLine("Hai indovinato. Il numero era: " + nc);
                        return;
                    }
                    if (tr > 0)
                    {
                        Console.WriteLine("Hai ancora " + tr + " tentativi rimasti");
                    }
                }
                Console.WriteLine("Game over, hai perso. Il numero era: " + nc);
            }
            else
            {
                nc = rnd.Next(1, 21);
                Console.WriteLine("E' stata scelta la difficoltà difficile");
                while (tr > 0)
                {
                    tr--;
                    Console.WriteLine("Inserisci un numero compreso tra 1 e 20");
                    string ns = Console.ReadLine();
                    n2i = int.TryParse(ns, out n);
                    while (!n2i || n > 20 || n < 1)
                    {
                        Console.WriteLine("Seleziona un numero valido");
                        ns = Console.ReadLine();
                        n2i = int.TryParse(ns, out n);
                    }
                    if (n > nc)
                    {
                        Console.WriteLine("Il numero inserito è troppo grande");
                        

                    }
                    else if (n < nc)
                    {
                        Console.WriteLine("Il numero inserito è troppo piccolo");
                        
                    }
                    else
                    {
                        Console.WriteLine("Hai indovinato. Il numero era: " + nc);
                        return;
                    }
                    if (tr > 0)
                    {
                        Console.WriteLine("Hai ancora " + tr + " tentativi rimasti");
                    }
                }
                Console.WriteLine("Game over, hai perso. Il numero era: " + nc);
            }
        }
    }
}

