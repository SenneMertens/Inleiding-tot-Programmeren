string voornaam, achternaam, magazine;
int keuze;

voornaam = Console.ReadLine();
achternaam = Console.ReadLine();
keuze = int.Parse(Console.ReadLine());

switch (keuze)
{
    case 1:
        magazine = "Anna";
        break;
    case 2:
        magazine = "Knippie";
        break;
    case 3:
        magazine = "VTWonen";
        break;
    case 4:
        magazine = "Voetbal International";
        break;
    case 5:
        magazine = "Wandelen & Fietsen";
        break;
    case 6:
        magazine = "Zoom NL";
        break;
    case 7:
        magazine = "Runners";
        break;
    default:
        magazine = "Geen suggestie";
        break;
}

Console.WriteLine($"{voornaam.ToLower()} {achternaam.ToUpper()}, Tijdschrift: {magazine}");