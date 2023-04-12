using System.ComponentModel;
using System;

int righe;
while (true){
    Console.Write("Indica un numero ('no' per uscire): ");
    string s = Console.ReadLine();

    if(s == "no"){
        Console.WriteLine("Ciao!");
        break;
    }
    righe = Convert.ToInt32(s);
    for (int r = 1; r<= righe;r++){
        for (int ast =1; ast <= r; ast++){
            Console.Write("* ");
        }
        Console.Write("\n ");
        }

    }     
    






    
    