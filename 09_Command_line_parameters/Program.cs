namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine($"You started me with {args.Length} arguments.");
			Console.WriteLine($"Arguments are {string.Join('|', args)}");
		}
	}
}


// Find out how to start the program using arguments on the commandline

// Find out how to start the program using arguments in the Debugger

// A better version how to parse arguments will follow!

