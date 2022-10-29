string doosRood, doosBlauw, doosExtra;

doosRood = Console.ReadLine();
doosBlauw = Console.ReadLine();

Console.WriteLine($"Doos rood: {doosRood}");
Console.WriteLine($"Doos blauw: {doosBlauw}");

doosExtra = doosRood;
doosRood = doosBlauw;
doosBlauw = doosExtra;

Console.WriteLine($"Doos rood na wissel: {doosRood}");
Console.WriteLine($"Doos blauw na wissel: {doosBlauw}");