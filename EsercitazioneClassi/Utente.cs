public class Utente{
   private string id;
   private string nome;
   private string cognome;
   private int annoIscrizione;
    
   public Utente(string id, string nome, string cognome, int annoIscrizione) {
      this.id = id;
      this.nome = nome;
      this.cognome = cognome;
      this.annoIscrizione = annoIscrizione;
   } 
   public string Denominazione() {
      return this.nome + " " + this.cognome;
   }
}

public class Libro{
   private string id;
   private string titolo;
   private string autore;
   private Utente utente;   
   
      
   public Libro(string id, string titolo, string autore){
      this.id = id;
      this.titolo = titolo;
      this.autore = autore;
      this.utente = null;
   }  
   public string Descrizione(){
      return this.titolo + " di " + this.autore;
   }
  
   public void Prestito(Utente utente){
      if (this.utente != null) {
         Console.WriteLine($"il libro {titolo} è gia in prestito a {this.utente.Denominazione()}");
         return;
      }
         this.utente = utente;
         Console.WriteLine($"Il libro {titolo} prestato a {this.utente.Denominazione()}");
   }
   public void Restituzione(){
      Console.WriteLine($"il libro {this.titolo} di {this.autore} è stato restituito da {this.utente.Denominazione()}"); 
      this.utente = null;
   }
}
public class Biblioteca{
   public static void Main(string[] args){
   Utente utente1 = new Utente("0001", "Mario", "Rossi",2015);
   Console.WriteLine(utente1.Denominazione());

   Utente utente2 = new Utente("0002", "Giuseppe", "Verdi",2012);
   Console.WriteLine(utente2.Denominazione());

   Libro libro = new Libro("L001", "Isola Misteriosa", "Giulio Verne");
   Console.WriteLine(libro.Descrizione());

   libro.Prestito(utente1);
   libro.Prestito(utente2);
   libro.Restituzione();
   libro.Prestito(utente2);
   }
}
