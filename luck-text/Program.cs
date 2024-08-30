

string namn;
string plats;
string spel;

// ctrl * kommenterar, alt pill ner eller up tar ner eller upp en rad i texten
// Consloe.WriteLine("Hello " + name + ");
// Console.WriteLine($"Hello {name}!");

Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor = ConsoleColor.Black;

// ränsar consolen
Console.Clear();

Console.WriteLine("Skriv in någons namn: ");
namn = Console.ReadLine();
Console.Clear();

Console.WriteLine("Skriv en plats: ");
plats = Console.ReadLine();
Console.Clear();

Console.WriteLine("Skriv ett spel: ");
spel = Console.ReadLine();
Console.Clear();

Console.WriteLine($"Igår bestämde sig {namn} att gå till {plats} och spela {spel} med sina vänner");
Console.ReadLine();