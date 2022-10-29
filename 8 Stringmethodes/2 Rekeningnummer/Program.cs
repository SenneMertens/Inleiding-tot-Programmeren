string input, rekeningnummer;
long eersteDeel;
int tweedeDeel;

do
{
    do
    {
        Console.Write($"Geef je rekeningnummer: ");
        input = Console.ReadLine();
    } while (input.Length != 14);
} while (input.Substring(3, 1) != "-" || input.Substring(11, 1) != "-");

rekeningnummer = input.Substring(0, 3);
rekeningnummer += input.Substring(4, 7);
rekeningnummer += input.Substring(12, 2);

eersteDeel = long.Parse(rekeningnummer.Substring(0, 10));
tweedeDeel = int.Parse(rekeningnummer.Substring(10, 2));

if (eersteDeel % 97 == tweedeDeel)
{
    Console.Write($"\n{input} is een geldig rekeningnummer");
}
else
{
    Console.Write($"\n{input} is geen geldig rekeningnummer");
}