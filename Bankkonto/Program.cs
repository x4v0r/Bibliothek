using System.Globalization;

class Program
{

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        var kim = new Konto("Kim");
        var sam = new Konto("Sam");
        kim.Einzahlen(500);
        kim.Abheben(120.50m);
        bool geklappt = kim.Abheben(1000);
        Console.WriteLine($"Abheben von 1000 möglich? {geklappt}");
        kim.Ueberweise(sam, 100);
        Console.WriteLine(kim.Kontoauszug());
        Console.WriteLine(sam.Kontoauszug());

    }

}