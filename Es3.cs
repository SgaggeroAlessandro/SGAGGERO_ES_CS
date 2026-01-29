namespace Es3;

internal class Program
{
    static void Main(string[] args)
    {
        int MCD, n1, n2, div, i;
        div = 1;
        bool n1i;
        bool n2i;
        Console.WriteLine("Inserisci un numero");
        string ni = Console.ReadLine();
        n1i = int.TryParse(ni, out n1);
        
        Console.WriteLine("Inserisci un numero");
        string ni2 = Console.ReadLine();
        n2i = int.TryParse(ni2, out n2);
        for (i = 1; i <= n1; i++)
        {
            bool div1 = false;
            bool div2 = false;
            if (n1%i== 0)
            {
                div1 = true;
            }
            if(n2%i== 0)
            {
                div2 = true;
            }
            if(div1 == true && div2 == true)
            {
                div = i;
            }
        }
        Console.WriteLine("Puoi organizzare i pezzi in gruppi da" + " " + div + " " + "riducendo i costi" );
    }
}