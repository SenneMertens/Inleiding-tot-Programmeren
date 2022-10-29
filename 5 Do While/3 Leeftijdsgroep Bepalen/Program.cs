string voornaam, achternaam, input, leeftijdsgroep, resultaat;

DateTime geboortedatum, leeftijd;

resultaat = string.Empty;

for (int i = 1; i <= 4; i++)
{
    Console.WriteLine($"Voor 4 personen gaan we de leeftijdsgroep bepalen!");

    do
    {
        Console.Write($"Persoon {i}, geef je voornaam: ");
        voornaam = Console.ReadLine();
    } while (string.IsNullOrEmpty(voornaam));

    do
    {
        Console.Write($"{voornaam}, geef je familienaam: ");
        achternaam = Console.ReadLine();
    } while (string.IsNullOrEmpty(achternaam));

    do
    {
        do
        {
            Console.Write($"{voornaam} {achternaam}, wanneer ben je geboren? ");
            input = Console.ReadLine();
        } while (! DateTime.TryParse(input, out geboortedatum));
    } while (geboortedatum > DateTime.Now);

    if (DateTime.Now.Year - geboortedatum.Year >= 18)
    {
        leeftijdsgroep = $"Volwassenen";
    }
    else if (DateTime.Now.Year - geboortedatum.Year >= 10)
    {
        leeftijdsgroep = $"Tiener";
    }
    else if (DateTime.Now.Year - geboortedatum.Year >= 3)
    {
        leeftijdsgroep = $"Kleuter";
    }
    else
    {
        leeftijdsgroep = $"Baby";
    }

    resultaat += $"\n{voornaam} {achternaam} - {DateTime.Now.Year - geboortedatum.Year} jaar - Leeftijdsgroep: {leeftijdsgroep}";
}

Console.WriteLine($"{resultaat}");