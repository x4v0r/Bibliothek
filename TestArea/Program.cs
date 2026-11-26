using TestArea;

Spieler spieler1 = new Spieler("Tom", 5);
Console.WriteLine(spieler1.Beschreibung());

Spieler spieler2 = new Spieler("Kim", 5);
Console.WriteLine(spieler2.Beschreibung());

Team team = new Team("Bayern");
team.SpielerHinzufuegen("Horst");
team.SpielerHinzufuegen("Dieter");
team.SpielerHinzufuegen("Bodo");
team.SpielerHinzufuegen(spieler1);
team.SpielerHinzufuegen(spieler2);

spieler1.Gewinne(5);

Console.WriteLine(team.Punkte);