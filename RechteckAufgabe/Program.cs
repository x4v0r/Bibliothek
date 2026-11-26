class Program
{
    public static void Main(string[] args)
    {
        var r1 = new Rechteck(4, 3);
        Console.WriteLine($"{r1.Beschreibung}");
        Console.WriteLine($"Alte Breite: {r1.Breite}");
        Console.WriteLine($"Alte Höhe: {r1.Hoehe}");
        r1.Breite = 12;
        r1.Hoehe = 12;
        Console.WriteLine($"{r1.Beschreibung}");
        Console.WriteLine($"Neue Breite: {r1.Breite}");
        Console.WriteLine($"Neue Höhe: {r1.Hoehe}");
    }
}