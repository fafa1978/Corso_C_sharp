using System;


int a= 500;
short b= 100;
sbyte c = -50;
long d = 100_000_000L;
int e = 0b10101010;
ushort f= 0x0a56;
//FLOAT e DOUBLE
float myFloat =10.57f;
double myDouble =10.57;
bool myBool = true;
string myString = "Ciao sono una stringa";

Console.WriteLine("a ={0}, b ={1}, c ={2},d ={3},e ={4},f ={5}",a,b,c,d,e,f);
Console.WriteLine($"a ={a}, b ={b}, c ={c},d ={d},e ={e},f ={f}");
Console.WriteLine($" la stessa cifra decimale viene scritta come Float {myFloat} sia come Double {myDouble} ");
Console.WriteLine($"  {myBool} ");
Console.WriteLine($"  {myString} ");
Console.WriteLine("-----------------------------------------------------------------------------------------");
Console.WriteLine($"a ={a}, b ={b}, c ={c},d ={d},e ={e},f ={f},la stessa cifra decimale viene scritta come Float {myFloat} sia come Double {myDouble}, o anche true/false {myBool} o {myString}");