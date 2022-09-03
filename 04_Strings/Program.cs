
Console.Write("Enter your name: ");
var name = Console.ReadLine();

var länge = name.Length;
Console.WriteLine($"Du heißt {name} und Dein Name ist {länge} Buchstaben lang");
	
Console.WriteLine("Wie heißt Du komplett?");
var nameKomplett = Console.ReadLine();
var wörter = nameKomplett.Split(',', ' ');


Console.WriteLine($"Dein Name besteht aus {wörter.Length} Worten");
Console.WriteLine(nameKomplett);
Console.WriteLine(wörter);
Console.WriteLine(nameKomplett.Contains("Graf"));
Console.WriteLine(nameKomplett.Contains("Mustermann"));
Console.WriteLine(nameKomplett.StartsWith("Schlau"));
Console.WriteLine(nameKomplett.EndsWith("mann"));

Console.WriteLine(nameKomplett.ToUpper());
Console.WriteLine(nameKomplett.ToLower());

Console.WriteLine(string.Join('-', wörter));
