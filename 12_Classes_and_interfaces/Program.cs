
var persons = new List<IPerson>();
persons.Add(new Adult() { Name = "Anton"  });
persons.Add(new Adult() { Name = "Berta"  });
persons.Add(new Child() { Name = "Caesar" });  // this does work because we have a list of IPersons!

Console.WriteLine($"All Persons: {string.Join(' ', persons)}\n\n");  // this does work because of override ToString !!


Console.WriteLine($"Hey persons, say something!");
foreach (IPerson person in persons)
	person.DoSomething();



interface IPerson
{
	string Name { get; set; }
	void DoSomething();
}

class Adult : IPerson
{
	public string Name { get; set; }
	public void DoSomething() { Console.WriteLine("Hello I'm an adult!"); }
	public override string ToString() { return Name; }
}

class Child : IPerson
{
	public string Name { get; set; }
	public void DoSomething() { Console.WriteLine("Hello I'm a child!"); }
	public override string ToString() { return Name; }
}
