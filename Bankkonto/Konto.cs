using System.Text;

public class Konto
{
    private static int _naechsteNummer = 1001; 

    public string Inhaber { get; }
    public int Nummer { get; }

    public decimal Stand { get; private set; }

    private List<string> _kontoauszuege = new List<string>();


    public Konto(string inhaber)
    {
        if (string.IsNullOrEmpty(inhaber))
        {
            throw new ArgumentException("Inhaber darf nicht leer sein!");
        }

        Inhaber = inhaber;
        Nummer = _naechsteNummer;
        _naechsteNummer++;
        Stand = 0m;
    }



    public void Einzahlen(decimal betrag)
    {
        if (betrag <= 0)
        {
            throw new ArgumentException("Betrag darf nicht negativ sein!");
        }
        else
        {
            Stand += betrag;
            _kontoauszuege.Add($"Einzahlung: {betrag}€");
        }
    }

    public bool Abheben(decimal betrag)
    {
        if (betrag <= 0)
        {
            throw new ArgumentException("Betrag darf niht negativ sein!");
            return false;
        }

        if (betrag < Stand)
        {
            Stand -= betrag;
            _kontoauszuege.Add($"Auszahlung: -{betrag}€");
            return true;
        }

        _kontoauszuege.Add($"Abgelehnt {betrag}€");
        return false;
    }

    public bool Ueberweise(Konto ziel, decimal betrag)
    {
        if (ziel == null)
        {
            throw new ArgumentNullException(nameof(ziel));
        }

        if (Abheben(betrag))
        {
            ziel.Einzahlen(betrag);
            return true;
        }
        return false;
    }

    public string Kontoauszug()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"Kontonummer: {Nummer} ({Inhaber})");

        foreach (string buchung in _kontoauszuege)
        {
            sb.AppendLine(buchung);
        }

        sb.AppendLine($"Stand {Stand}€");
        return sb.ToString();
    }
}