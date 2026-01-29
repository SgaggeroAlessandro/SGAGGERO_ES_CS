namespace Es4;

internal class Program
{
    static void Main(string[] args)
    {
        int mi;
        int s = 0;
        int c = 0;
        int r = 0;
        bool ni;
        string n;
        Console.WriteLine("Questo programma calcola quante monete servono per arrivare a 5 euro. Tutti i valori devono essere espressi in centesimi");
        Console.WriteLine("I valori possibili sono:");
        Console.WriteLine("1");
        Console.WriteLine("2");
        Console.WriteLine("5");
        Console.WriteLine("10");
        Console.WriteLine("20");
        Console.WriteLine("50");
        Console.WriteLine("100 (1 euro)");
        Console.WriteLine("200 (2 euro)");
        while (s < 500)
        {
            Console.WriteLine("Inserisci un valore:");
             n = Console.ReadLine();
            ni = int.TryParse(n, out mi);
            if(mi != 1 && mi != 2 && mi != 5 && mi != 10 && mi != 20 && mi != 50 && mi != 100 && mi != 200)
            {
                Console.WriteLine("Inserisci un valore valido:");
                 n = Console.ReadLine();
                ni = int.TryParse(n, out mi);
            }
            else
            {
                s = s + mi;
                c++;
            }
        }
        if (s > 500)
        {
            r = s - 500;
            Console.WriteLine("Ci sono volute" + " " + c + " " + "monete per raggiungere i 5 euro");
            Console.WriteLine("Il resto è di " + " " + r + " " + "centesimi");
        }
        else
        {
            Console.WriteLine("Ci sono volute" + " " + c + " " + "monete per raggiungere i 5 euro");
        }
    }
}