using System.Data.SqlTypes;

class program
{
    public static void Main(string[] args)
    {
        
    }
}


class Buch{
    
    public string Titel { get; }
    public string Autor { get; }
    public List<string> Buchliste = new List<string>(); 
    
    //Konstruktor
    public Buch(string titel, string autor)
    {
        if (titel == null || autor == null)
        {
            throw new ArgumentNullException("Titel und Autor dürfen nicht leer sein!");
        }
        Titel = titel;
        Autor = autor;
    }
    
    
}