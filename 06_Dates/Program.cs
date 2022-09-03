
using Microsoft.VisualBasic;
using System;
using System.Globalization;
using System.Runtime.Intrinsics.X86;

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

var start = DateTime.Now;
var ende = DateTime.Now;
var differenz = ende - start;
var sekunden = differenz.TotalSeconds;


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
var dateAsString = "28.12.1967";
var parsedString = DateTime.ParseExact(dateAsString, "dd.MM.yyyy", CultureInfo.InvariantCulture);
Console.WriteLine($"input  {dateAsString}");
Console.WriteLine($"output {parsedString}");


// ATTENTION: THIS HERE WILL NEVER WORK !!!

if (DateTime.Now.ToString() == "01/01/2022 00:00:00")
	Console.WriteLine("Happy new year");

// Sharing Date values:
// it depends.
// 1. When you share appointments around the world, use UTC times.
//    For example, when you makea appointment to meet with others, you wanna do this
//    because a date should be the same in every region of the world.
//
// 2. When you share local things related to the person, use local time without timezone
//    For example if you want to set your alarm clock, you want to be alarmed at 8 am,
//    regardless where in the world you are.
