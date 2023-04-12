using System;

namespace esercizio2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[,] arr = new int [5,5];
            int counter=0;
            for (i=0 ;i < 5; i++){
                for (j =0 ; j < 5; j++){
                    ++counter;
                    arr[i,j]=(j==0)?0:counter;
                }
            }
            for (i =0 ;i < 5; i++){
                for (j =0 ; j < 5; j++){
                    Console.Write($"{arr[i,j]} ");
                Console.Write("\n");
                }
            }
        } 
    } 
}