int leeftijd, geboortemaand;
string resultaat;

leeftijd = int.Parse(Console.ReadLine());
geboortemaand = int.Parse(Console.ReadLine());

switch (leeftijd)
{
    case <= 2:
        switch (geboortemaand)
        {
            case <= 7:
                resultaat = "Peuterklas";
                break;
            case > 7:
                resultaat = "Eerste kleuterklas";
                break;
        }
        break;
    case <= 4:
        resultaat = "Tweede kleuterklas";
        break;
    case >= 5:
        resultaat = "Derde kleuterklas";
        break;
}

Console.WriteLine($"{resultaat}");