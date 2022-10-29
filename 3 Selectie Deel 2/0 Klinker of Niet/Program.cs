string letter, resultaat;

letter = Console.ReadLine();

switch (letter.ToUpper())
{
    case "A":
    case "E":
    case "I":
    case "O":
    case "U":
        resultaat = "Klinker";
        break;
    default:
        resultaat = "Medeklinker";
        break;
}

Console.WriteLine($"{resultaat}");