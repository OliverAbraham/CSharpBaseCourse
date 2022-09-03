using System.Globalization;

Console.WriteLine($"String formatting and parsing:\n\n");

Console.WriteLine(@"
These are the three ways to format:
  1. "" . . . {variable,Format} . . . ""    Example: Console.WriteLine($""{amount, N2}"");
  2. string.Format(Format, variable)      Example: var text = string.Format(""N2"", amount);
  3. variable.ToString(Format)            Example: var text = amount.ToString(""N2"");
They are interchangeable.
");


Console.WriteLine($"\n\n\nNumbers:");
decimal pi = 3.1415m;
Console.WriteLine($"Left aligned                     : {pi,-10}");
Console.WriteLine($"Right aligned leading blanks     : {pi,10}");
Console.WriteLine($"Right aligned leading zeroes     : {pi:0000000.00}");
decimal amount = 1234.56m;
Console.WriteLine($"Right aligned thousand separators: {amount,10:N2}");
Console.WriteLine($"Right aligned leading zeroes     : {amount:000,000.00}");
int value = 1000;
Console.WriteLine($"Hexadecimal                      : {value:x}");



Console.WriteLine($"\n\n\nparsing numbers:");
var myTextWithNumber = "12345.67";
var format = new CultureInfo("en-EN");
bool success = decimal.TryParse(myTextWithNumber, NumberStyles.AllowDecimalPoint, format, out decimal myAmount);
Console.WriteLine($"Parsing '{myTextWithNumber}' resultet in '{myAmount}'");



Console.WriteLine($"\n\n\nStrings:");
var txt = "Example";
Console.WriteLine($"Left aligned                     : {txt,-10}");
Console.WriteLine($"Right aligned                    : {txt,10}");



Console.WriteLine($"\n\n\nDate and time:");
var now = DateTime.Now;
Console.WriteLine($"Date out of the box              : {now}");
Console.WriteLine($"Short date format                : {now:d}");
Console.WriteLine($"Long date format                 : {now:D}");
Console.WriteLine($"Short time format                : {now:t}");
Console.WriteLine($"Long time format                 : {now:T}");
Console.WriteLine($"Complete short                   : {now:f}");
Console.WriteLine($"Complete long                    : {now:F}");
Console.WriteLine($"Individual                       : {now:yyyy_MM_dd___HH_mm_ss}");
Console.WriteLine($"Timestamp format for logs        : {now:yyyy-MM-dd HH:mm:ss fff}");



Console.WriteLine($"\n\n\nparsing Dates and Times:");
var myTextWithDate = "24.12.2000";
var myDateFormat = new CultureInfo("en-EN");
success = DateTime.TryParseExact(myTextWithDate, "dd.MM.yyyy", null, DateTimeStyles.None, out DateTime myDate);
Console.WriteLine($"Parsing '{myTextWithDate}' resultet in '{myDate}'");

var myTextWithTime = "11.22.33";
success = DateTime.TryParseExact(myTextWithTime, "HH.mm.ss", null, DateTimeStyles.NoCurrentDateDefault, out DateTime myTime);
Console.WriteLine($"Parsing '{myTextWithTime}'   resultet in '{myTime}'");
