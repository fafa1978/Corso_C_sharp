using System;

namespace MetodiRicorsivi
{
    class Program
    {    
        static void Main(string[] args)
        {
            Console.Write("Inserisci un numero: ");
            int n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"il fattoriale di {n} è {Fattoriale(n)}");
            }
            

            static int Fattoriale(int n){
                if(n==0)
                    return 1;
                return n*Fattoriale(n -1);
                  
            }
    }    
}    