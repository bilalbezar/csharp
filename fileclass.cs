//Introduction to C# IO namespace and file class

class NameSpc
{
	public static void Main(string[] args)
	{
		System.Console.WriteLine("Copy Source File .........");
		System.IO.File.Copy("D:\\Documents and Settings\\Administrator\\My Documents\\Visual Studio Projects\\ConsoleApplication3\\Class2.cs","copied.cs",true);
		System.Console.WriteLine("Copied....................");
	}
}
