
int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c);
	
a = 7;
b = 4;
c = 3;
int d = (a + b) / c;
int e = (a + b) % c;
Console.WriteLine($"quotient: {d}");
Console.WriteLine($"rest: {e}");

int jahr = 2000;
int rest = jahr % 4;
var schaltjahr = rest == 0;
Console.WriteLine($"Ist das Jahr {jahr} ein Schaltjahr? {schaltjahr}");
	
int DeinAlter = 17;
var volljährig = DeinAlter >= 18;
Console.WriteLine($"Bist Du volljährig? {volljährig}");



