while (true)
{
    Console.Write("Passwort: ");
    string Eingabe = Console.ReadLine();

    if (String.IsNullOrEmpty(Eingabe))
    {
        break;
    }
    
    List<string> PruefePasswort(string passwort)
    {
        List<string> Meldungen = [];
        bool hatZiffer = false;
        bool hatGrossbuchstabe = false;
        bool hatKleinbuchstabe = false;
        bool hatLeerzeichen = false;
        
    
        if (passwort.Length < 8)
        {
            Meldungen.Add($"Passwort zu kurz! ({passwort.Length} von 8 Zeichen)");
        }

        foreach (char c in passwort)
        {
            if (char.IsDigit(c))
            {
                hatZiffer = true;
            }
        
            if (char.IsUpper(c))
            {
                hatGrossbuchstabe = true;
            }

        
            if (char.IsLower(c))
            {
                hatKleinbuchstabe = true;
            }

    
            if (char.IsWhiteSpace(c))
            {
                hatLeerzeichen = true;
            }
        }
    
        
        if (hatZiffer == false)
        {
            Meldungen.Add("Passwort hat keine Ziffern!");
        }

        if (hatGrossbuchstabe == false)
        {
            Meldungen.Add("Passwort hat keine Großbuchstaben!");
        }

        if (hatKleinbuchstabe == false)
        {
            Meldungen.Add("Passwort hat keine Kleinbuchstaben!");
        }

        if (hatLeerzeichen == true)
        {
            Meldungen.Add("Passwort enthält Leerzeichen!");
        }

        if (passwort.Contains("passwort", StringComparison.OrdinalIgnoreCase))
        {
            Meldungen.Add("Das Wort 'Passwort' darf nicht im Passwort enthalten sein");
        }

        if (Meldungen.Count == 0)
        {
            Console.WriteLine("Passwort ist sicher!");
        }
        
        Console.WriteLine(string.Join(" ", Meldungen));
        return Meldungen;
    }
    
    PruefePasswort(Eingabe);
}


