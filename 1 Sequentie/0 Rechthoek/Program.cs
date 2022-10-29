int korteZijde, langeZijde, omtrek, oppervlakte;

korteZijde = int.Parse(Console.ReadLine());
langeZijde = int.Parse(Console.ReadLine());

omtrek = (korteZijde * 2) + (langeZijde * 2);
oppervlakte = korteZijde * langeZijde;

Console.WriteLine($"Omtrek: {omtrek}");
Console.WriteLine($"Oppervlakte: {oppervlakte}");