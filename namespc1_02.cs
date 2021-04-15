//C# Name space name concept 
//If we don't want to write name space again and again
//We can still give namespace just by typing "using" keyword

using System;

class NameSpc
{

	public static void Main(string[] args)
	{
		//Observe no system is preceding console
		Console.WriteLine("Write Line one");
		//NameSpc.ABC(); //It works
		ABC();
	}

	static void ABC()
	{
		System.Console.WriteLine("Function Abc called");
	}

}


