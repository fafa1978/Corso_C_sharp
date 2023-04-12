// See https://aka.ms/new-console-template for more information
// double d = 15.6;
// int a = 10 + d;
// int a = double a;
// Console.WriteLine(a);
Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("Implicito");
int a = 10;
double d = a + 15.6;
Console.WriteLine(a);
Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("Esplicito");
double d1 = 15.6;
int a1 = 10 + (int)d1;
Console.WriteLine(a);
