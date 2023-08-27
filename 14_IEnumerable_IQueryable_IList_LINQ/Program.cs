
// LINQ means "Language INtegrated Query"

// -------------------- CREATING SAMPLE DATA --------------------

List<Person> myList = new List<Person>
{
	new Person("Keith", "Richards"),
	new Person("Elvis", "Presley"),
	new Person("Aaron", "Carter"),
};


// -------------------- PRINTING OUT THE WHOLE LIST --------------------

// we want to print the list:
Console.WriteLine($"this doesn't work               : {myList}");
Console.WriteLine($"this doesn't work either        : {string.Join(", ", myList)}");
Console.WriteLine($"this doesn't work either sorry  : {string.Join(", ", myList.ToString())}");

// we print the list in an old fashioned way (we dont wanna do this anymore!)
// I have created a method for this:
WriteListOfPersons("The whole list                  : ", myList);
Console.WriteLine();
Console.WriteLine();




// -------------------- SELECTING PROPERTIES OUT OF EACH ELEMENT --------------------

// We use the "Select" method from the "LINQ" technology to go through all list elements and fetch a part out of every element
// to use LINQ operators, we have to use lambda expressions:
// remember:
// a lambda expression is something that has a fat arrow and something left and right, like this:
// (a,b) => a+b
// the form we are using here is:
// x => x.SOMETHING
// x represents the current list element, and SOMETHING a property of the list element (Person here)

var firstNames = myList.Select(x => x.FirstName);
Console.WriteLine($"only the first Names            : {string.Join(", ", firstNames)}");

// what is happening?
// the Select method calls the lambda for every list element
// then takes the return values of the lambda and builds a new list out of them.


// we also could write this without a lambda (dont do it, just for demo!!!)
firstNames = myList.Select(PickOutTheFirstNameOfAnElement);

string PickOutTheFirstNameOfAnElement(Person element)
{
    return element.FirstName;
}




// -------------------- DOING SOME STUFF WITH THE ELEMENTS --------------------

var lastNames = myList.Select(x => x.LastName);
Console.WriteLine($"only the last Names             : {string.Join(", ", lastNames)}");

var lengths = myList.Select(x => x.LastName.Length);
Console.WriteLine($"Lengths of the last names       : {string.Join(", ", lengths)}");

var combineThings = myList.Select(x => x.FirstName + x.LastName);
Console.WriteLine($"combine first and last names    : {string.Join(", ", combineThings)}");





// -------------------- FILTERING THE ELEMENTS --------------------------------

// select certain elements
var allPresleys = myList.Where(x => x.LastName == "Presley");
WriteListOfPersons("allPresleys                     : ", allPresleys);

// select only one element
var thePresley = myList.Where(x => x.LastName == "Presley").FirstOrDefault();
WritePerson("thePresley                      : ", thePresley);

// when I'm sure I will find it
var theOnlyPresley = myList.Where(x => x.LastName == "Presley").First();
WritePerson($"my only Presley                 : ", theOnlyPresley);

// select persons with a certain criteria:
var namesStartingWithP = myList.Where(x => x.LastName.StartsWith("P")).Select(x => x.LastName);
Console.WriteLine($"last names starting with a p    : {string.Join(", ", namesStartingWithP)}");

// select persons with a certain criteria:
var longNames = myList.Where(x => x.LastName.Length > 7).Select(x => x.LastName);
Console.WriteLine($"very long names                 : {string.Join(", ", longNames)}");




// -------------------- CHECKING IF I HAVE A CERTAIN ELEMENT ------------------

var doIHaveAPresley = myList.Any(x => x.LastName == "Presley");
Console.WriteLine($"Do I have a Presley ?           : {string.Join(", ", doIHaveAPresley)}");




// -------------------- SORTING -----------------------------------------------

// sort by first name:
var sortedByFirstname = myList.OrderBy(x => x.FirstName);
WriteListOfPersons($"sortedByFirstname               : ", sortedByFirstname);




// -------------------- COMBINING LINQ OPERATORS ------------------------------


// sort by last name but only take the first name:
var sortedByLastName = myList.OrderBy(x => x.LastName).Select(x => x.FirstName).ToList();
Console.WriteLine($"sortedByLastName                : {string.Join(", ", sortedByLastName)}");



// -------------------- AGGREGATION -------------------------------------------

List<Person> newList = new List<Person>
{
	new Person("Paul", "Carter"),
	new Person("Al", "Jarreau"),
};
var combinedList = myList.Concat(newList).ToList();
Console.WriteLine($"combined lists                  : {string.Join(", ", combinedList.Select(x => x.FirstName + x.LastName))}");




// -------------------- SEARCHING ---------------------------------------------

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




// -------------------- INTERSECTION ------------------------------------------

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








void WriteListOfPersons(string text, IEnumerable<Person> myList)
{
	Console.Write(text);
	foreach (var person in myList)
		Console.Write(person.FirstName + " " + person.LastName + ",");
	Console.WriteLine();
}

void WritePerson(string text, Person oneElement)
{
	Console.Write(text);
	Console.Write(oneElement.FirstName + " " + oneElement.LastName);
	Console.WriteLine();
}

