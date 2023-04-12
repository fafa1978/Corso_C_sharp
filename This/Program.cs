using System.Reflection.Metadata;
class Persona{
    private string nome;
    private string cognome

    public Persona(string cognome):this("Mario", cognome){
        }

    public Persona():this("Mario", "Rossi) {

    }    
       public Persona(string nome, string cognome){
    this.nome=nome;
    this.cognome=cognome;
    }
 
}