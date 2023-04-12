using System;

public class Persona{
    private string nome;                            \\estese a tutta la classe
    private string cognome;
    
    public Persona(string p_nome, string p_cognome) \\variabili locali a livello di metodo {
       if (p_nome == "mario"){
        string s = "Ciao Mario!";                   \\variabili a livello di blocco
        Console.WriteLine(s);
       }


       nome= p_nome;
       cognome= p_cognome;
    }
    


















}