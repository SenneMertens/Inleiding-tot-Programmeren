string input;
int getal, som;

som = 0;

do
{
    Console.Write($"Geef een getal: ");
    input = Console.ReadLine();
} while (string.IsNullOrEmpty(input));

for (int i = 0; i < input.Length; i++)
{
    getal = int.Parse(input.Substring(i, 1));
    som += getal;
}

Console.WriteLine($"Som: {som}");