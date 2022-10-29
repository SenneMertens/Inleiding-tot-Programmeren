string voornaam, achternaam, leeftijdsgroep;
int leeftijd;

voornaam = Console.ReadLine();
achternaam = Console.ReadLine();
leeftijd = int.Parse(Console.ReadLine());

leeftijdsgroep = "Jeugd";

if (leeftijd >= 18)
{
    leeftijdsgroep = "Volwassenen";
}

Console.WriteLine($"{voornaam} {achternaam}: {leeftijdsgroep}");