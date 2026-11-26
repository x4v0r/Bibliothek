namespace TestArea;

public class Spieler
{
    public string Name { get;}
    public int Punkte { get; private set; }

    public Spieler(string spielerName, int spielerPunkte = 0)
    {
        if (string.IsNullOrWhiteSpace(spielerName))
        {
            throw new ArgumentNullException("Spieler name ist leer");
        }

        Name = spielerName;
        Punkte = spielerPunkte;
    }

    public void Gewinne(int gewonnenePunkte)
    {
        Punkte += gewonnenePunkte;
    }

    public string Beschreibung()
    {
        return $"{Name} {Punkte}";
    }
}