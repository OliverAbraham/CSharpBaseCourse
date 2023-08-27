
class Program
{
	static void Main(string[] args)
	{
		// lets create a method to add some values:
		Console.WriteLine($"Adding something        : {Add(3,4)}");

		// and also one to subtract
		Console.WriteLine($"Subtracting something   : {Subtract(3,4)}");

		// lets do the calc and the print together:
		Console.WriteLine($"Do all at once: ");
		CalculateAndPrint(5, 6, Add);

		// we want to get rid of the method and write it smaller:
		// the following thing is called a "delegate":
		// we have copy-pasted the method, removed the return type and replaced the method name by the word "delegate":

		CalculateAndPrint(5, 6,           delegate(int a, int b) { return a + b; } );
		
		// if our short "method" only has one line with a "return", we can save the word "delegate"
		// and replace the curly braces by an arrow.
		// the following is called a "lambda" or "lambda expression":
		// and the => is called a "fat arrow"

		CalculateAndPrint(5, 6,           (int a, int b) => a + b );

		// we can also remove the parameter types:

		CalculateAndPrint(5, 6,           (a, b) => a + b );

		// this here:       (a, b) => a + b       is called a "lambda" or "lambda expression":
		

		// speak    : "a and b goes to a times b"
		// in german: "für alle a und b gilt a mal b"

		// Please note: 
		// there are two concepts named as "delegate"
		// the "delegate" below (delegate in MathFunction) is a type definition for functions.
		// the delegate above (line 13) is an anonymous function.


		// THE ONLY IMPORTANT THING TO REMEMBER:
		// a lambda expression is something that has a fat arrow and something left and right
		// its a kind of inline function that we need for the "LINQ" technique.

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
