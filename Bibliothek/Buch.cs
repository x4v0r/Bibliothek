namespace BibliothekAufgabe;
public class Buch{
    
    public string Titel { get; }
    public string Autor { get; }
    public bool IstAusgeliehen { get; private set; }
    
    

    public bool Ausleihen()
    {
        if (IstAusgeliehen)
        {
            return false;
        }
        IstAusgeliehen = true;
        return true;

    }

    public void Zureuckgeben()
    {
        if (IstAusgeliehen)
        {
            IstAusgeliehen = false;
            Console.WriteLine($"{Titel} wurde zurückgegeben");
        }
    }

    public string Beschreibung()
    {
       
        string status = IstAusgeliehen ? "ausgeliehen" : "verfügbar";
        return $"{Titel} ({Autor}) - {status}";
    }
    
    
    //Konstruktor
    public Buch(string titel, string autor)
    {
        if (string.IsNullOrEmpty(titel))
        {
            throw new ArgumentNullException("Titel darf nicht leer sein!");
        }

        if (string.IsNullOrEmpty(autor))
        {
            throw new ArgumentNullException("Autor darf nicht leer sein!");
        }
        
        Titel = titel;
        Autor = autor;
    }
}