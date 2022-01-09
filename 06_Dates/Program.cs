
using System.Globalization;

var aDate = new DateTime();
Console.WriteLine($"just a date: {aDate}");

var now = DateTime.Now;
Console.WriteLine($"Formatting 'out of the box'      : |{now}|");
Console.WriteLine($"short date format                : |{now:d}|");
Console.WriteLine($"long date format                 : |{now:D}|");
Console.WriteLine($"short time format                : |{now:t}|");
Console.WriteLine($"long time format                 : |{now:T}|");
Console.WriteLine($"complete short                   : |{now:f}|");
Console.WriteLine($"complete long                    : |{now:F}|");
Console.WriteLine($"individual                       : |{now:yyyy_MM_dd___HH_mm_ss}|");
Console.WriteLine($"Timestamp format for logs        : |{now:yyyy-MM-dd HH:mm:ss fff}|");
Console.WriteLine($"Take only the date out of it     : |{now.Date}|");
Console.WriteLine($"Take only the time out of it     : |{now.TimeOfDay}|");
// Get familiar with the rest of the date properties!


Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"ATTENTION! Be aware of the implicit formatting of region and language settings!!!");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"formatting using the explicit culture de-DE: |{now.ToString(CultureInfo.CreateSpecificCulture("de-DE"))}|");
Console.WriteLine($"formatting using the explicit culture fr-FR: |{now.ToString(CultureInfo.CreateSpecificCulture("fr-FR"))}|");
Console.WriteLine($"formatting using the explicit culture en-US: |{now.ToString(CultureInfo.CreateSpecificCulture("en-US"))}|");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"ATTENTION! Be aware of the implicit formatting of numbers!!!");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

decimal currencyAmount = 12345678.99m;
Console.WriteLine($"formatting using the explicit culture de-DE: |{currencyAmount.ToString("N2", CultureInfo.CreateSpecificCulture("de-DE"))}|");
Console.WriteLine($"formatting using the explicit culture fr-FR: |{currencyAmount.ToString("N2", CultureInfo.CreateSpecificCulture("fr-FR"))}|");
Console.WriteLine($"formatting using the explicit culture en-US: |{currencyAmount.ToString("N2", CultureInfo.CreateSpecificCulture("en-US"))}|");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


TimeSpan myTimeSpan = new TimeSpan(0,11,22,33,44);
//Console.WriteLine($"just a timespan  : {myTimeSpan.ToString("HH:mm:ss")}            <--- this doesn't work");
Console.WriteLine($"instead do this  : {myTimeSpan.ToString(@"dd\.hh\:mm\:ss")}");
Console.WriteLine($"or this          : {myTimeSpan.ToString(@"hh\:mm\:ss")}");


Console.WriteLine($"Timestamp DateTime parsing");
var dateAsString = "20000304";  // the fourth of march 2000
//var parsedString = DateTime.ParseExact(dateAsString, "yyyyMMdd'T'HHmmss", CultureInfo.InvariantCulture);
var parsedString = DateTime.ParseExact(dateAsString, "yyyyMMdd", CultureInfo.InvariantCulture);
Console.WriteLine($"input  {dateAsString}");
Console.WriteLine($"output {parsedString}");


// ATTENTION: THIS HERE WILL NEVER WORK !!!

if (DateTime.Now.ToString() == "01/01/2022 00:00:00")
   Console.WriteLine("Happy new year");
