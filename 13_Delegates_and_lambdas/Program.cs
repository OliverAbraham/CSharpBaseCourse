
class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine($"Adding something        : {Add(3,4)}");
		Console.WriteLine($"Subtracting something   : {Subtract(3,4)}");

		Console.WriteLine($"Do all at once: ");
		CalculateAndPrint(5, 6, Add);


		CalculateAndPrint(5, 6,           delegate(int a, int b) { return a + b; }          );  // <--- this is called a "delegate"
		
		CalculateAndPrint(5, 6,           (int a, int b) => a + b                           ); // <--- this is called a "lambda" or "lambda expression"

		CalculateAndPrint(5, 6,           (a, b) => a + b                                   ); // <--- this is called a "lambda" or "lambda expression"

		CalculateAndPrint(5, 6,           (a, b) => a * b                                   ); //  the => is called a "fat arrow". 

		// speak    : "a and b goes to a times b"
		// in german: "für alle a und b gilt a mal b"

		// the "delegate" below is a type definition for functions.
		// the delegate above is an anonymous function.
	}

	static int Add(int a, int b)
	{
		return a + b;
	}

	static int Subtract(int a, int b)
	{
		return a - b;
	}



	delegate int MathFunction(int a, int b);

	static void CalculateAndPrint(int x, int y, MathFunction f)
	{
		var result = f(x, y);
		Console.WriteLine(result);
	}
}
