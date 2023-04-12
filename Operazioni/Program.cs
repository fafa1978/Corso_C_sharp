// See https://aka.ms/new-console-template for more information

int a = 10 + 5;
int b = 10 - 5;
int c = 10 * 5;
double d = 10 / 6;
int e = -a;
int f = 10 + 5 *2;
int f2 = (10 + 5) *2;

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(e);
Console.WriteLine(f);
Console.WriteLine(f2);
Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("Operatori per l'assegnazione composta");
int a1 = 10;
int b1= a1 += 3;
Console.WriteLine(a1);
Console.WriteLine(b1);
Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("Operatori di incremento e decremento");
a1 ++;
Console.WriteLine(a1);
b1 --;
Console.WriteLine(b1);
Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("Esempio");

int a2 = 10;
int b2 = 5 + ++a2;
Console.WriteLine(a2);
Console.WriteLine(b2);
Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");
int a3 = 10;
int b3 = 5 + a3++;
Console.WriteLine(a3);
Console.WriteLine(b3);




