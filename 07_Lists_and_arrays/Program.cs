
// ARRAYS

string[] myFirstArray = new string[] { "peter", "paul", "mary" };
string[] mySecondArray	= new string[] { "are", "sitting", "in the kitchen" };
Console.WriteLine($"myFirstArray            : {string.Join('*', myFirstArray)}");
Console.WriteLine($"mySecondArray           : {string.Join('*', mySecondArray)}");


var completeArray = mySecondArray.Concat(myFirstArray).ToArray();
Console.WriteLine($"Both arrays together    : {completeArray}");
Console.WriteLine($"Both arrays together    : {string.Join('*', completeArray)}");
Console.WriteLine("\n\n\n");


foreach(var element in completeArray)
{
	Console.WriteLine($"{element}");
}


// LISTS

List<string> myFirstList	= new List<string> { "this", "is", "my" };
List<string> mySecondList	= new List<string> { "first", "list", "program" };
Console.WriteLine($"myFirstList             : {string.Join('*', myFirstList)}");
Console.WriteLine($"mySecondList            : {string.Join('*', mySecondList)}");
myFirstList.Add("hurray");

// CONSTRUCTING LISTS

List<string> myThirdList = new List<string>();
myThirdList.Add("tick");
myThirdList.Add("trick");
myThirdList.Add("track");


// SHORTER FORMS

var myFourthList = new List<string>();
List<string> myFifthList = new();



// COMBINING LISTS

// you won't do this:
//var bothLists = mySecondList.Concat(myFirstList).ToArray();
// you want to do this:
var completeList = new List<string>();
completeList.AddRange(mySecondList);
completeList.AddRange(myFirstList);

Console.WriteLine($"Both lists together     : {completeList.ToString()}");
Console.WriteLine($"Both lists together     : {string.Join('*', completeList)}");
Console.WriteLine("\n\n\n");


// SORTING (BETTER WAYS LATER WITH LINQ)

completeList.Sort();
Console.WriteLine($"Sortedlist (sorted with extension method)    : {string.Join('*', completeList)}");
Console.WriteLine("\n");



// WORKING WITH THE ELEMENTS

Console.Write($"Enumerating the list                         : ");
foreach(var item in completeList) Console.Write($"{item}! ");
Console.WriteLine("\n");



// CHANGING ITEMS, INSERTING, REMOVING, CLEARING

myFirstList[0] = "Peter";
myFirstList.RemoveAt(0);
myFirstList.Insert(1, "gustav");
myFirstList.Clear();
