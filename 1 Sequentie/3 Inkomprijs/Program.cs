int aantalKinderen, aantalVolwassenen;
const double prijsKinderen = 7.5, prijsVolwassenen = 10;
double totaalPrijs;

aantalKinderen = int.Parse(Console.ReadLine());
aantalVolwassenen = int.Parse(Console.ReadLine());
totaalPrijs = (prijsKinderen * aantalKinderen) + (prijsVolwassenen * aantalVolwassenen);

Console.WriteLine($"Totaal te betalen: {totaalPrijs:0.00} euro");