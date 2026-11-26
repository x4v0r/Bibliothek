/*
int zahl = 1;
int multiplier = 1;
int zeile = 1;
int spalte = 1;

Console.WriteLine("   |    1   2   3   4   5   6   7   8   9  10");
Console.WriteLine(new string('-', 45));

for (zeile = 1; zeile <=10; zeile++)
{
    Console.Write($"{zeile,2} | ");
    for (spalte = 1; spalte <= 10; spalte++)
    {
        Console.Write($"{zeile * spalte,4}");
    }

    Console.WriteLine("");
}
*/


int spalte = 0;
int zeile = 0;

Console.Write("Anzahl Spalten: ");
spalte = int.Parse(Console.ReadLine()?? "");

Console.Write("Anzahl Zeilen: ");
zeile = int.Parse(Console.ReadLine()?? "");

Console.WriteLine("");

Console.Write("     |");
for (int i = 1; i <= spalte; i++)
{
    Console.Write($"{i, 4}");
}

Console.WriteLine();

Console.WriteLine(new string('-', 6 + (spalte * 4)));

for (int i = 1; i <= spalte; i++)
{
    Console.Write($"{i, 4} |");
    for (int j = 1; j <= zeile; j++)
    {
        Console.Write($"{i * j, 4}");
    }

    Console.WriteLine();
}
