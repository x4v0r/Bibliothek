using TestArea;

public class Team
{
    public string Name { get;}

    public int Punkte
    {
        get
        {
            int summe = 0;
            foreach (Spieler spieler in Spieler)
            {
                summe += spieler.Punkte;
            }
            return summe;
        }
    }
    public List<Spieler> Spieler { get; }

    
    public Team(string name)
    {
        Name = name;
        Spieler = new List<Spieler>();
    }

    public void SpielerHinzufuegen(string name)
    {
        Spieler s = new Spieler(name);
        Spieler.Add(s);
    }

    public void SpielerHinzufuegen(Spieler spieler)
    {
        Spieler.Add(spieler);
    }

    public void SpielerEntfernen(Spieler spieler)
    {
        Spieler.Remove(spieler);
    }
}