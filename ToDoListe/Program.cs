using System.Text;
var ToDo = new List<string>();


while (true)
{
    Console.WriteLine("1) Hinzufügen   2) Auflisten   3) Entfernen   4) Suchen   5) Exportieren   0) Beenden");
    Console.Write("Auswahl: ");
    var Eingabe = (Console.ReadLine() ?? "").Trim();


    if (Eingabe == "1")
    {
        Console.Write("Aufgabe: ");
        var Eintraege = (Console.ReadLine() ?? "");
        var teile = Eintraege.Split(new[] { ';', ',' },
            StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

        foreach (var teil in teile)
        {
            bool schonDrin = false;
            foreach (var aufgabe in ToDo)
            {
                if (string.Equals(aufgabe, teil, StringComparison.OrdinalIgnoreCase))
                {
                    schonDrin = true;
                    Console.WriteLine($"{teil} steht bereits auf der Liste");
                    break;
                }
            }

            if (!schonDrin)
            {
                ToDo.AddRange(teil);
                Console.WriteLine($"{teil} wurde der Liste hinzugefügt");
            }
        }
    }


    else if (Eingabe == "2")
    {
        foreach (string aufgabe in ToDo)
        {
            Console.WriteLine($"{ToDo.IndexOf(aufgabe) + 1}. {aufgabe}");
        }

        if (ToDo.Count == 0)
        {
            Console.WriteLine("Die Liste ist leer.");
        }
    }

    else if (Eingabe == "3")
    {
        if (ToDo.Count == 0)
        {
            Console.WriteLine("Die Liste ist leer.");
            continue;
        }
        
        Console.Write("Lösche Aufgabe: ");
        string? Eintrag = Console.ReadLine();
        if (Eintrag == null)
        {
            continue;
        }

        if (int.TryParse(Eintrag, out int nummer) && nummer >= 1 && nummer <= ToDo.Count)
        {
            string geloeschteAufgabe = ToDo[nummer - 1];
            ToDo.RemoveAt(nummer - 1);
            Console.WriteLine($"Erledigte Aufgabe: {geloeschteAufgabe}");
        }
    }
    
    else if (Eingabe == "4")
    {
        Console.Write("Suchbegriff: ");
        string? begriff = Console.ReadLine();

        if (string.IsNullOrEmpty(begriff))
        {
            break;
        }

        int treffer = 0;
        for (int i = 0; i < ToDo.Count; i++)
        {
            if (ToDo[i].Contains(begriff, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"{i + 1, 3}. {ToDo[i]}");
                treffer++;
            }
        }

        Console.WriteLine($"{treffer} Treffer.");
    }
    
    else if (Eingabe == "5")
    {
        var datum = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
        string trennLinie = new string('=', 40);
        
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"ToDo Liste von {datum} Uhr");
        sb.AppendLine(trennLinie);

        foreach (string todo in ToDo)
        {
            sb.AppendLine($"[] {todo}");
        }
        sb.AppendLine(trennLinie);
        sb.AppendLine($"{ToDo.Count} offene Aufgaben");
        
        var tabelle = sb.ToString();
        Console.WriteLine(tabelle);
    }
    
    else if (Eingabe == "0" || Eingabe is null)
    {
        Console.WriteLine("Auf Wiedersehen!");
        break;
    }

    else
    {
        Console.WriteLine("Unbekannte Eingabe");
    }
}


//Lösung mit Try & Catch (Eingabe == 3) statt TryParse
        
/*
Console.Write("Lösche Aufgabe: ");
int Loeschen = int.Parse(Console.ReadLine() ?? ""); // int.TryParse(Console.ReadLine(), out Eintrag);

try
{
    string geloeschteAufgabe = ToDo[Loeschen - 1];
    ToDo.RemoveAt(Loeschen - 1);
    Console.WriteLine($"Erledigte Aufgabe: {geloeschteAufgabe}");
}
catch (ArgumentOutOfRangeException)
{
    Console.WriteLine($"Bitte eine Nummer zwischen 1 und {ToDo.Count} eingeben.");
}
*/