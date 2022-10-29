int nationaleOproepen, internationaleOproepen;
const double vastBedrag = 23, gesprekskosten = 0.12, btw = 1.21;
double totaalPrijs;

nationaleOproepen = int.Parse(Console.ReadLine());
internationaleOproepen = int.Parse(Console.ReadLine());

totaalPrijs = (vastBedrag + ((nationaleOproepen + internationaleOproepen) * gesprekskosten)) * btw;

Console.WriteLine($"Totaal te betalen: {totaalPrijs:0.00} euro");