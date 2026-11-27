namespace BibliothekAufgabe;

public class Bibliothek
{
    private List<Buch> _buecher = new List<Buch>();

    public int Anzahl
    {
        get
        {
            return _buecher.Count;
        } 

    }

    public int AnzahlVerfuegbar()
    {
        int verfuegbar = _buecher.Count;
        foreach (var buch in _buecher)
        {
            
            if (buch.IstAusgeliehen)
            {
                verfuegbar--;
            }
        }
        return verfuegbar;
    }
    
    public void Hinzufuegen(Buch buch)
    {
        if (buch is null)
        {
            throw new ArgumentNullException(nameof(buch), "Buch nicht gefunden");
        }

        if (!_buecher.Contains(buch))
        {
            _buecher.Add(buch);    
        }
        
    }

    public List<Buch> Suche(string text)
    {
        List<Buch> Suchergebnisse = new List<Buch>();

        foreach (Buch buch in _buecher)
        {
            if (buch.Titel.Contains(text, StringComparison.OrdinalIgnoreCase))
            {
                Suchergebnisse.Add(buch);
            }

            if (buch.Autor.Contains(text, StringComparison.OrdinalIgnoreCase))
            {
                Suchergebnisse.Add(buch);
   
            }
        }
        
        return Suchergebnisse;
    }

    public bool Ausleihen(string titel)
    {
        foreach (var buch in _buecher)
        {
            if (buch.Titel.Equals(titel, StringComparison.OrdinalIgnoreCase))
            {
                if (buch.Ausleihen() == true)
                {
                    Console.WriteLine($"{buch.Titel} wurde ausgeliehen!");
                }
                else
                {
                    Console.WriteLine($"{buch.Titel} ist bereits verliehen!");
                }
            }
        }
        return true;
    }

    public void BuchListe()
    {
        foreach (var buch in _buecher)
        {
            Console.WriteLine(buch.Beschreibung());
        }
    }
    
}