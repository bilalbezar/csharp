using System;

class GetInput
{

	public static void Main(string[] args)
	{
		string username, other;
		//======================
		Console.WriteLine("User Name:");
		username = Console.ReadLine();
		other = Environment.GetEnvironmentVariable("PATH");
		Console.WriteLine(other);
	}
}