
class Program
{
	static List<Person> myList = new List<Person>
	{
		new Person("Keith", "Richards"),
		new Person("Elvis", "Presley"),
		new Person("Aaron", "Carter"),
	};

	static void Main(string[] args)
	{
		var printer = new ListPrinter<Person>();
		printer.Print(myList);
	}


	class ListPrinter<T>
	{
		public void Print(List<T> list)
		{
			foreach(var item in list)
				Console.WriteLine(item);
		}
	}
}
