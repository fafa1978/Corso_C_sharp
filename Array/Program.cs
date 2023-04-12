
using System;
// int[]x = new int[] {5,15,50,9,12,1,0,90,45,15};

// Console.WriteLine(x[5]);//stampa la sesta cifra dell'array

// Console.WriteLine("---------------------------------------------------------------------------------");

// Console.WriteLine("arrey multidimensionali");
// int[][] a = new int[4][];
// a [0] = new int[] {5,15,50,9,12,1,0,90,45,15};
// a [1] = new int[] {15,50,9,12,1,0,90,45,15};
// a [2] = new int[] {50,9,12,1,0,90,45,15};
// a [3] = new int[] {9,12,1,0,90,45,15};

// Console.WriteLine(a[0][0]); //stampa il primo array del primo rigo

// Console.WriteLine("oppure si può scrivere cosi");
// int[][] b ={ 
//  new int[] {5,15,50,9,12,1,0,90,45,15},
//  new int[] {15,50,9,12,1,0,90,45,15},
//  new int[] {50,9,12,1,0,90,45,15},
//  new int[] {9,12,1,0,90,45,15},
// };
// Console.WriteLine(b[1][2]); //stampa il terzo numero del secondo rigo

// Console.WriteLine("\n int[][] b ={ "
//  +"\n new int[] {5,15,50,9,12,1,0,90,45,15},"
//  +"\n new int[] {15,50,9,12,1,0,90,45,15},"
//  +"\n new int[] {50,9,12,1,0,90,45,15},"
//  +"\n new int[] {9,12,1,0,90,45,15},"
// +"};"); //stampa il terzo numero del secondo rigo

// Console.WriteLine("---------------------------------------------------------------------------------");

// Console.WriteLine("FOR EACH");

// int[] z = new int[]{5,15,50,9,12,1,0,90,45,15};
//     foreach (int value in z)
//         Console.WriteLine(value);
// Console.WriteLine("ForEach con Array Multidimensionali");
// Console.WriteLine("---------------------------------------------------------------------------------");
// int[][] w ={ 
//  new int[] {5,15,50,9,12,1,0,90,45,15},
//  new int[] {15,50,9,12,1,0,90,45,15},
//  new int[] {50,9,12,1,0,90,45,15},
//  new int[] {9,12,1,0,90,45,15},
// };
// foreach (int value in w[3])
//         Console.WriteLine(value);

// Console.WriteLine("FOR LOOP");
// Console.WriteLine("---------------------------------------------------------------------------------");

// // int[]x = new int[] {5,15,50,9,12,1,0,90,45,15};
// //     for(int i=0 ; i < x.length ; i++)
// //         Console.WriteLine(x[i]);


Console.WriteLine("Esercizio");
Console.WriteLine("---------------------------------------------------------------------------------");
int[,] arr = new int [5,5];
    int counter=0;
    for (i=0;i<5;i++){
        for (j=0;j<5;j++){
            ++counter;
            arr[i,j]=(j==0)?0:counter;
        }
    }
    