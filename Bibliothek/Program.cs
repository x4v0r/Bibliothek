using BibliothekAufgabe;

class Program
{
    public static void Main(string[] args)
    {
        Buch buch1 = new Buch("Der Hobbit", "J. R. R. Tolkien");
        Buch buch2 = new Buch("Der Herr der Ringe", "J. R. R. Tolkien");
        Buch buch3 = new Buch("Clean Code", "Robert C. Martin");
        Buch buch4 = new Buch("Momo", "Michael Ende");
        Bibliothek bibliothek = new Bibliothek();
        
        bibliothek.Hinzufuegen(buch1);
        bibliothek.Hinzufuegen(buch2);
        bibliothek.Hinzufuegen(buch3);
        bibliothek.Hinzufuegen(buch4);
        
        // Verfügbar X von X
        Console.WriteLine($"Verfügbar: {bibliothek.AnzahlVerfuegbar()} von {bibliothek.Anzahl}");
        
        
        bibliothek.BuchListe();

        Console.WriteLine("\n ==================================== \n");
        
        foreach (var buch in bibliothek.Suche("Herr"))
        {
            Console.WriteLine($"Suchergebnisse: {buch.Beschreibung()}");
        }
        bibliothek.Ausleihen("der herr der ringe");
        bibliothek.Ausleihen("Faust");
        
        Console.WriteLine("\n ==================================== \n");
        
        Console.WriteLine($"Verfügbar: {bibliothek.AnzahlVerfuegbar()} von {bibliothek.Anzahl}");
        bibliothek.BuchListe();
        
        Console.WriteLine("\n ==================================== \n");
        
        buch2.Zureuckgeben();
        
        Console.WriteLine("\n ==================================== \n");
        
        bibliothek.BuchListe();
    }
}