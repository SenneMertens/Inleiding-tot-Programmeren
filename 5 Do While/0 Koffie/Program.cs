int uren;
double koffie;
string input;

uren = 0;

do
{
    Console.Write($"Hoeveelheid koffie (MG): ");
    input = Console.ReadLine();
} while (! double.TryParse(input, out koffie));

do
{
    koffie /= 2;
    uren += 5;
} while (koffie >= 1);

Console.WriteLine($"Totale tijd: {uren} uur");