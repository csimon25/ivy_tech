using System;
using System.Collections.Generic;

public class Program
{
	// DO NOT EDIT
	private static void Main()
	{
		// Program execution will begin here.
		// If you don't have a way to run a C# program, you can use this link:
		// https://www.programiz.com/csharp-programming/online-compiler/
		RunProgram();
	}

   // TODO - EDIT:
   static void RunProgram()
{
   var points = InitializePoints();
   var commands = new List<char> { 'a', 'p', 'q' };
		
   while (true)
   {
    
       var command = GetCommand(commands);
		
       if (command == 'a')
       {
	   AddPoint(points);
       }
       else if (command == 'p')
       {
	   PrintPoints(points);
       }
       else if (command == 'q')
       {
           break;
       }
   }
}

	// DO NOT EDIT
	private static void AddPoint( List<(double x, double y)> points )
	{
		double x;
		double y;

		// Add a point to the list.
		Console.Write( "Enter a value for x: " );
		while( !Double.TryParse( Console.ReadLine(), out x ) )
		{
			Console.WriteLine( "Invalid value." );
			Console.Write( "Enter a value for x: " );
		}

		Console.Write( "Enter a value for y: " );
		while( !Double.TryParse( Console.ReadLine(), out y ) )
		{
			Console.WriteLine( "Invalid value." );
			Console.Write( "Enter a value for y: " );
		}

		points.Add( (x, y) );
	}

	// DO NOT EDIT
	private static char GetCommand( List<char> commands )
	{
		char command;

		Console.Write( "Press 'a' to add a point, 'p' to print points, or 'q' to quit: " );
		while( !Char.TryParse( Console.ReadLine(), out command ) || !commands.Contains( command ) )
		{
			Console.WriteLine( "Invalid command." );
			Console.Write( "Press 'a' to add a point, 'p' to print points, or 'q' to quit: " );
		}

		return command;
	}

	// DO NOT EDIT
	private static List<(double x, double y)> InitializePoints()
	{
		// This is a list of x,y coordinates.
		var points = new List<(double x, double y)>();

		// Here we add an initial set of items to the list.
		points.Add( (1.0, 2.2) );
		points.Add( (1.3, 2.2) );
		points.Add( (4.0, 2.7) );
		points.Add( (1.0, 3.2) );

		return points;
	}

	// DO NOT EDIT
	private static void PrintPoints( List<(double x, double y)> points )
	{
		// Print the x and y coordinate of each point in the list.
		Console.WriteLine( "Existing points:" );
		foreach( var point in points )
			Console.WriteLine( $"x = {point.x}, y = {point.y}" );
	}
}
