using System;

namespace StatementCase{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("scrivi qualcosa: ");
            string s = Console.ReadLine();

            if (s == "primo")
                Console.WriteLine("hai scritto 'primo'");
            else if (s == "secondo")
                Console.WriteLine("hai scritto 'secondo'");
            else
                Console.WriteLine($"hai scritto {s}");

            switch (s){
            case "primo":
                Console.WriteLine("hai scritto 'primo'");
                break;
            case "secondo":
                Console.WriteLine("hai scritto 'secondo'");
                break;
            default:
                Console.WriteLine($"hai scritto '{s}'");
                break;
            }
        }
    }  
} 


// int s = 20;

// switch (s){
//     case 10:
//     Console.WriteLine("Valore 20,case 10");
//     break;
//     case 20:
//     Console.WriteLine("valore 20,case 20");
//     break;
//     case 30:
//     Console.WriteLine("valore 20,case 30");
//     break;
//     default:
//     Console.WriteLine("Un altro valore");
//     break;
// }

