# CSharpBaseCourse example code

This repository contains several demo programs from my C# Pro Course.

## Hello World
	• 01_HelloWorld
	• 02_HelloWorld
	• 03_Basic_input_output

## Strings
	• 04_Strings

## Numbers
	• 05_Numbers
	• 05_Numbers2
	• 05_Numbers3

## Dates
	• 06_Dates
	• Dates are a data type
	• Never compare dates as int, strings
	• Beware of implicit input: Current culture, Timezone!
	• Bad Example: 
		if (DateTime.Now.ToString() == "01/01/2022 00:00:00")
			Console.WriteLine("Happy new year");
	• DateTime.UtcNow (without Timezone)
	• Beware of ISO8601 Format
	• Taking only the day and only the time out of a DateTime
	• DateTimeOffset type
	• https://www.youtube.com/watch?v=Y195oMMLlqM
	• Sharing Date values:
		it depends. When you share appointments around the world, use UTC times.
		When you share local things related to the person, use local time without timezone
	

## Lists and Arrays
	• 07_Lists_and_arrays

## Command line parameters
	• 09_Command_line_parameters

## Environment Variables
	• 10_Environment_variables

## Files and Directories
	• 11_files_and_directories

## OOP: Classes, Interfaces
	• 12_Classes_and_interfaces (needed for DataBinding and more)

## Delegates and Lambdas
	• 13_Delegates_and_lambdas
	• declare two methods Add and Subtract
	• Then explain delegate: delegate int MathOp(int a, int b);
	• New method: void CalculateAndPrint(int a, int b, MathOp f);
	• call CalculateAndPrint, firstly with delegate:
		CalculateAndPrint (3,4,Add);
	• then convert the Add to a delegate:
		CalculateAndPrint (3,4, int Add(int x, int y) { return x+y; }  );
		CalculateAndPrint (3,4, int delegate(int x, int y) { return x+y; }  );
		CalculateAndPrint (3,4, delegate(int x, int y) { return x+y; }  );
	• The method becomes a delegate by deleting the return value andreplacing thename by the word 'delegate'
	• Then convert to a lambda expression, and reduce further:
		CalculateAndPrint (3,4, (int x, int y) => { return x+y; }  ); ("fat arrow")
		CalculateAndPrint (3,4, (int x, int y) => x+y );
		CalculateAndPrint (3,4, (x, y) => x+y ); (der Compiler findet die Typen selber heraus)

	• A lambda function is also only a delegate.
	• The first "delegate" is a type definition for functions
	• The second "delegate" is an "anonymous function". 
	• Means that it doesn't have a name (the compile has one)
	
## IEnumerable IQueryable IList LINQ
	• 14_IEnumerable_IQueryable_IList_LINQ
	• LINQ queries are important to understand more complex programs
	• LINQ makes it easy to program common tasks
	• LINQ is important for using databases
	• LINQ makes programs better readable
	• LINQ is a kind fo functional programming

	
## Generics
	•  15_Generics
