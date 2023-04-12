using System;

float f = 12.5f;
double d =130.78;
decimal dm =1500.456m;
double ne = 5e-7;
var s= "type inference";
var b = false;

Console.WriteLine("le variabili da visualizzare sono : {0}, {1},{2},{3},{4},{5}",f,d,dm,ne,s,b);

Console.WriteLine($"le variabili da visualizzare sono : {f}, {d},{dm},{ne},{s},{b}");