// ===== Aufgabe G01 - 1 ===== //

Console.WriteLine("Name: ");
string name = Console.ReadLine();
Console.WriteLine("Age: ");
int alter = int.Parse(Console.ReadLine());
Console.WriteLine("Größe: ");
double groesse = double.Parse(Console.ReadLine());
Console.WriteLine("Lieblingsbuchstabe: ");
char buchstabe = char.Parse(Console.ReadLine());
bool volljaehrig;


if (alter >= 18)
{
    volljaehrig = true;
}
else
{
    volljaehrig = false;
}


Console.WriteLine("Name:" + name);
Console.WriteLine("Alter:" + alter);
Console.WriteLine("Größe:" + groesse +"m");
Console.WriteLine("Lieblingsbuchstabe:" + buchstabe);
Console.WriteLine("Volljährig: " + volljaehrig);


// ===== Aufgabe G01 - 2 ===== //


Console.WriteLine("Zahl: ");
int zahl = int.Parse(Console.ReadLine());

if (zahl % 2 == 0)
{
    Console.WriteLine(zahl + " ist gerade!");
}
else
{
    Console.WriteLine(zahl + " ist ungerade!");
}



// ===== Aufgabe G01 - 3 ===== //

Console.Write("Jahr: ");
int jahr = int.Parse(Console.ReadLine() ?? "");

if (jahr % 100 != 0 && jahr % 4 == 0 || jahr % 400 == 0)
{
    Console.WriteLine(jahr + " ist ein Schaltjahr");
    Console.WriteLine("Der Februar hat 29 Tage");
}

else
{
    Console.WriteLine(jahr + " ist kein Schaltjahr");
    Console.WriteLine("Der Februar hat 28 Tage");
}


// ===== Aufgabe G01 - 4 ===== //

Console.WriteLine("Punktzahl: ");
int punkte = int.Parse(Console.ReadLine());

int note = 0;


if (punkte > 100 || punkte < 0)
{
    Console.WriteLine("Bitte eine Punktzahl von 0 bis 100 eingeben!");
    return;
}

if (punkte >= 92)
{
    note = 1;
}

else if (punkte >= 81)
{
    note = 2;
}

else if (punkte >= 67)
{
    note = 3;
}

else if (punkte >= 50)
{
    note = 4;
}

else if (punkte >= 30)
{
    note = 5;
}

else
{
    note = 6;
}

var text = note switch
{
    1 => "Sehr gut",
    2 => "gut",
    3 => "befriedigend",
    4 => "ausreichend",
    5 => "mangelhaft",
    6 => "ungenügend"
};

Console.WriteLine($"{note} {text}");

if (note >= 5)
{
    Console.WriteLine("Leider nicht bestanden!");
}


// ===== Aufgabe A04 - 1+2 ===== //

int session = 3*60*60*1000;
int playtime = 0;
int counter = 0;

for (int loop = 0; loop < 250; loop++)
{
    try
    {
        checked
        {
            playtime += session;
            counter++;  
        }
        
    }
    catch (OverflowException ex)
    {
        Console.WriteLine($"FEHLER: {counter}: {playtime}");
        break;
    }
    
    if (counter > 195 && counter < 203)
    {
        Console.WriteLine($"{counter,3}: {playtime,14 :N0}");
    }
    
}

Console.WriteLine($"Gesamtspielzeit: {playtime:N0}");



// ===== Aufgabe A04 - 3 ===== //

int session = 3*60*60*1000;
long playtime = 0;
int counter = 0;
long stunden = 0;
long maxloops = long.MaxValue/session;

for (int loop = 0; loop < 250; loop++)
{
    playtime += session; 
    counter++;

    Console.WriteLine($"{counter,3}: {playtime,14:N0}");
}

stunden = playtime/1000/60/60;

Console.WriteLine("Spielzeit:");
Console.WriteLine($"{playtime:N0}ms");
Console.WriteLine($"{stunden}std");
Console.WriteLine($"Maximale Durchläufe: {maxloops:N0}");


// ===== Aufgabe A04 - 4 ===== //

TimeSpan Sitzungsdauer = TimeSpan.FromHours(3);

TimeSpan GesamtZeit = TimeSpan.Zero;

int AnzahlSitzungen = 250;

for (int Sitzung = 1; Sitzung <= AnzahlSitzungen; Sitzung++)
{
    GesamtZeit += Sitzungsdauer;
}

Console.WriteLine($"Gesamtzeit: {GesamtZeit.TotalHours:N0} Stunden");
Console.WriteLine($"Gesamtzeit: {GesamtZeit.Days}Tage {GesamtZeit.Hours} Stunden");


// ===== Aufgabe G02 - Aufgabe 1 ===== //


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

// ===== Aufgabe A04 - Aufgabe 2 - Etappe 1-3 ===== //


Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal Gesamtpreis = 0m;
decimal GesamtpreisRabatt = 0;
decimal Einzelpreis = 0.1m;
decimal RabattSchwelle = 1.00m;
decimal Rabatt = 0.05m;

Console.Write("Anzahl Kaugummis: ");
decimal AnzahlArtikel = decimal.Parse(Console.ReadLine());

for (int i = 0; i < AnzahlArtikel; i++)
{
    Gesamtpreis += Einzelpreis;
}

Console.WriteLine($"Gesamtpreis: {Gesamtpreis:F2}€");

if (Gesamtpreis >= RabattSchwelle)
{
    GesamtpreisRabatt = Gesamtpreis - (Gesamtpreis * Rabatt);
    Console.WriteLine("5% Rabatt!");
    Console.WriteLine($"Kaufpreis:  {GesamtpreisRabatt:F2}€");
}

else
{
    Console.WriteLine("Kein Rabatt!");
    Console.WriteLine($"Kaufpreis: {Gesamtpreis:F2}€");
}


// ===== Aufgabe A04 - Aufgabe 2 - Etappe 4 ===== //


using System.Globalization;
Console.OutputEncoding = System.Text.Encoding.UTF8;

CultureInfo de = CultureInfo.GetCultureInfo("de-DE");
CultureInfo en = CultureInfo.GetCultureInfo("en-US");
CultureInfo gb = CultureInfo.GetCultureInfo("en-GB");
CultureInfo inv = CultureInfo.InvariantCulture;


string[] zeilen = ["Kaffee;2.50", "Croissant;1.80", "Wasser;0.99"];
decimal SummeOhneKultur = 0.0m;

foreach (string eintrag in zeilen)
{
    string[] teile = eintrag.Split(';');
    decimal preis = decimal.Parse(teile[1],inv);
    SummeOhneKultur += preis;
    Console.WriteLine($"{teile[0],-12}{preis.ToString("C", de), 10}");
}

Console.WriteLine(new String('-', 22));
Console.WriteLine($"{"Summe:",-12} {SummeOhneKultur.ToString("C", de),10}");


// ===== Aufgabe G02 - Aufgabe 2 ===== //

var liste = new List<int>();
int counter = 0;

while (true)
{ 
    Console.Write("Zahl eingeben:");
    int zahl = int.Parse(Console.ReadLine());

        
    if (zahl != 0)
    {
        liste.Add(zahl);
        counter++;
                
    }
        
    else if (liste.Count == 0 && zahl == 0)
    {
        Console.WriteLine("Keine Zahl eingeben.");
        return;
    }
        
    else
    {
        break;
    }
}



double Gesamt(List<int> werte)
{
    double sum = 0;
    foreach (var zahl in werte)
    {
        sum += zahl;
    }
    return sum;
}


double Durchschnitt(List<int> werte)
{
    double sum = 0;
    foreach (var zahl in werte)
    {
        sum += zahl;
    }
    return sum/werte.Count;
}


double Maximum(List<int> werte)
{
    int max = liste[0];
    foreach (var zahl in werte)
    {
        if (zahl > max)
        {
            max = zahl;
        }
    }
    return max;
}
