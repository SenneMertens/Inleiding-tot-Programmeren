string woord, woordZonderKlinkers;

woordZonderKlinkers = string.Empty;

do
{
    Console.Write($"Geef een woord: ");
    woord = Console.ReadLine();
} while (string.IsNullOrEmpty(woord));

for (int i = 0; i < woord.Length; i++)
{
    switch (woord.ToLower().Substring(i, 1))
    {
        case "a":
        case "e":
        case "i":
        case "o":
        case "u":
            woordZonderKlinkers += $"";
            break;
        default:
            woordZonderKlinkers += $"{woord.Substring(i, 1)}";
            break;
    }
}

Console.WriteLine($"Het woord zonder klinkers is {woordZonderKlinkers}");