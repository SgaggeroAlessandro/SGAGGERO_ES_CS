using System;

namespace Es1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Dato un numero N in input, questo programma calcola i numeri primi compresi tra 1 e N");
            Console.WriteLine("Inserisci il numero");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("I numeri primi compresi tra 1 e " + N + ":");
            for (int i = 2; i <= N; i++)
            {
                bool np = true;
              for(int j = 2; j <= i/2; j++){
                  if(i % j== 0){
                    np = false;
                      break;
                  }
        }
                if(np == true){
                    Console.WriteLine(i);
    }

}
    }
}
}
