const double gbp = 1.08, usd = 0.77;
double bedrag;
string wisselkoers;

bedrag = double.Parse(Console.ReadLine());
wisselkoers = Console.ReadLine();

if (wisselkoers == "GBP")
{
    Console.WriteLine($"{wisselkoers}: {bedrag * gbp}");
}
else if (wisselkoers == "USD")
{
    Console.WriteLine($"{wisselkoers}: {bedrag * usd}");
}
else
{
    Console.WriteLine($"Foutieve wisselkoers");
}