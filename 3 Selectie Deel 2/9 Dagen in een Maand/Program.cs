string maand, resultaat;

maand = Console.ReadLine();

switch (maand.ToLower())
{
    case "januari":
        resultaat = "31 dagen";
        break;
    case "februari":
        resultaat = "28/29 dagen";
        break;
    case "maart":
        resultaat = "31 dagen";
        break;
    case "april":
        resultaat = "30 dagen";
        break;
    case "mei":
        resultaat = "31 dagen";
        break;
    case "juni":
        resultaat = "30 dagen";
        break;
    case "juli":
        resultaat = "31 dagen";
        break;
    case "augustus":
        resultaat = "31 dagen";
        break;
    case "september":
        resultaat = "30 dagen";
        break;
    case "oktober":
        resultaat = "31 dagen";
        break;
    case "november":
        resultaat = "30 dagen";
        break;
    case "december":
        resultaat = "31 dagen";
        break;
    default:
        resultaat = "Foutieve invoer";
        break;
}

Console.WriteLine($"{resultaat}");