double bedrag;
const double gbp = 1.08, usd = 0.77;

bedrag = double.Parse(Console.ReadLine());

Console.WriteLine($"EUR: {bedrag:0.00}");
Console.WriteLine($"GBP: {bedrag * gbp:0.00}");
Console.WriteLine($"USD: {bedrag * usd:0.00}");