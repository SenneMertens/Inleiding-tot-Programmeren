double prijsExcBtw, btwPercentage, btw, prijsIncBtw;

prijsExcBtw = double.Parse(Console.ReadLine());
btwPercentage = int.Parse(Console.ReadLine());

btw = (btwPercentage / 100) + 1;
prijsIncBtw = prijsExcBtw * btw;

Console.WriteLine($"Prijs inclusief BTW: {prijsIncBtw:0.00}");