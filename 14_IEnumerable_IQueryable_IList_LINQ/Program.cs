
// LINQ means "Language INtegrated Query"

List<Person> myList = new List<Person>
{
	new Person("Keith", "Richards"),
	new Person("Elvis", "Presley"),
	new Person("Aaron", "Carter"),
};


// -------------------- SELECTION --------------------

Console.WriteLine($"the complete List:              : {myList}");
Console.WriteLine($"the complete List:              : {string.Join(", ", myList.ToString())}");

// to use LINQ operators, we have to use lambda expressions:

var firstNames = myList.Select(x => x.FirstName);
Console.WriteLine($"only the first Names            : {string.Join(", ", firstNames)}");

var firstNames2 = myList.Select(x => x.FirstName).ToList();
Console.WriteLine($"only the first Names            : {string.Join(", ", firstNames2)}");


var firstAndLastNames = myList.Select(x => x.FirstName + x.LastName).ToList();
Console.WriteLine($"first and last names            : {string.Join(", ", firstAndLastNames)}");

// select persons with last name starting with a p:
var namesStartingWithP = myList.Where(x => x.LastName.StartsWith("P")).Select(x => x.LastName);
Console.WriteLine($"last names starting with a p    : {string.Join(", ", namesStartingWithP)}");

// select very long names:
var longNames = myList.Where(x => x.LastName.Length > 7).Select(x => x.LastName);
Console.WriteLine($"very long names                 : {string.Join(", ", longNames)}");



// -------------------- SORTING ----------------------

// sort by first name:
var sortedByFirstname = myList.OrderBy(x => x.FirstName).ToList();

// sort by last name:
var sortedByLastName = myList.OrderBy(x => x.LastName).Select(x => x.FirstName + x.LastName).ToList();

Console.WriteLine($"sortedByFirstname               : {string.Join(", ", sortedByFirstname)}");
Console.WriteLine($"sortedByLastName                : {string.Join(", ", sortedByLastName)}");




// -------------------- AGGREGATION ----------------------

List<Person> newList = new List<Person>
{
	new Person("Paul", "Carter"),
	new Person("Al", "Jarreau"),
};
var combinedList = myList.Concat(newList).ToList();
Console.WriteLine($"combined lists                  : {string.Join(", ", combinedList.Select(x => x.FirstName + x.LastName))}");




// -------------------- SEARCHING -------------------------

// find the element with A:
var theElementWithA = myList.FirstOrDefault(x => x.FirstName.StartsWith("A"));
if (theElementWithA != null)	
	Console.WriteLine($"theElementWithA                 : {theElementWithA.FirstName + theElementWithA.LastName}");
else
	Console.WriteLine($"theElementWithA                 : NOT FOUND!");

// find the element with B:
var theElementWithB = myList.FirstOrDefault(x => x.FirstName.StartsWith("B"));
if (theElementWithB != null)	
	Console.WriteLine($"theElementWithB                 : {theElementWithB.FirstName + theElementWithB.LastName}");
else
	Console.WriteLine($"theElementWithB                 : NOT FOUND!");

// take the first element:
var theFirstElement = myList.First();
var theLastElement  = myList.Last();
Console.WriteLine(    $"the first and the last          : {theFirstElement.FirstName + theFirstElement.LastName} {theLastElement.FirstName + theLastElement.LastName}");


// does the list contain an element?
Console.WriteLine(    $"is my list empty?               : {!myList.Any()}");




// -------------------- INTERSECTION -----------------------

// find the elements that have the same last name in both lists:
var sameElementsInBothLists = (from x in myList 
							   where newList.Any(y => y.LastName == x.LastName)
							   select x)
							   .ToList();
Console.WriteLine(    $"same last name in both lists    : {string.Join(", ", sameElementsInBothLists.Select(x => x.FirstName + x.LastName))}");


// other way, but same result:
var sameElementsInBothLists2 = (from x in myList 
							   join y in newList on x.LastName equals y.LastName
							   select x)
							   .ToList();
Console.WriteLine(    $"same last name in both lists    : {string.Join(", ", sameElementsInBothLists2.Select(x => x.FirstName + x.LastName))}");


