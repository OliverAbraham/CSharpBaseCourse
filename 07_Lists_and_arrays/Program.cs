
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

// you won't do this:
//var bothLists = mySecondList.Concat(myFirstList).ToArray();
// you want to do this:
var completeList = new List<string>();
completeList.AddRange(mySecondList);
completeList.AddRange(myFirstList);

Console.WriteLine($"Both lists together     : {completeList.ToString()}");
Console.WriteLine($"Both lists together     : {string.Join('*', completeList)}");
Console.WriteLine("\n\n\n");


completeList.Sort();
Console.WriteLine($"Sortedlist (sorted with extension method)    : {string.Join('*', completeList)}");
Console.WriteLine("\n");

Console.Write($"Enumerating the list                         : ");
foreach(var item in completeList) Console.Write($"{item}! ");
Console.WriteLine("\n");

myFirstList[0] = "Hallo";
//myFirstList.RemoveAt()
//myFirstList.Insert();
myFirstList.Clear();
