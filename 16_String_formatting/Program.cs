using StringFormattingSpecial;

Console.WriteLine($"Zahlen:");
decimal pi = 3.1415m;
Console.WriteLine($"Linksbündig                      : |{pi,-10}|");
Console.WriteLine($"Rechtsbündig führende Leerzeichen: |{pi,10}|");
Console.WriteLine($"Rechtsbündig führende Nullen     : |{pi:0000000.00}|");
decimal betrag = 1234.56m;
Console.WriteLine($"Rechtsbündig Tausenderpunkte     : |{betrag,10:N2}|");
Console.WriteLine($"Rechtsbündig Tsdpkt Vornullen    : |{betrag:000,000.00}|");
int zahl = 1234;
Console.WriteLine($"Hexadezimal                      : |{zahl:x}|");


Console.WriteLine($"\nTexte:");
var txt = "Beispiel";
var langtxt = "BeispieltextLang";
Console.WriteLine($"Linksbündig                      : |{txt,-10}|");
Console.WriteLine($"Rechtsbündig                     : |{txt,10}|");
Console.WriteLine($"Linksbündig mit Abschneiden      : |{langtxt.MaxLength(10):-10}|");
Console.WriteLine($"Rechtsbündig mit Abschneiden     : |{langtxt.MaxLength(10):10}|");


Console.WriteLine($"\nDatum und Uhrzeit:");
var heute = DateTime.Now;
Console.WriteLine($"Datum out of the box             : |{heute}|");
Console.WriteLine($"kurzes Datumsformat              : |{heute:d}|");
Console.WriteLine($"langes Datumsformat              : |{heute:D}|");
Console.WriteLine($"kurzes Zeitformat                : |{heute:t}|");
Console.WriteLine($"langes Zeitformat                : |{heute:T}|");
Console.WriteLine($"komplett kurz                    : |{heute:f}|");
Console.WriteLine($"komplett lang                    : |{heute:F}|");
Console.WriteLine($"Individuell                      : |{heute:yyyy_MM_dd___HH_mm_ss}|");
Console.WriteLine($"Timestamp-Format für Logs        : |{heute:yyyy-MM-dd HH:mm:ss fff}|");




Console.WriteLine($"\nThese are the three variants of formatting:");
Console.WriteLine("  - variant1: $\" . . . {variable,Format} . . . \"");
Console.WriteLine("  - variant2: string.Format(Format, variable)");
Console.WriteLine("  - variant3: variable.ToString(Format)");

var variable = 1234567.89m;
var format   = "N2";

var variant1 = $" . . . {variable:N3} . . . ";
var variant2 = string.Format("{0:N2}", variable);
var variant3 = variable.ToString(format);

Console.ReadKey();
