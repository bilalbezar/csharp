//C# Name space name concept 
//System.Console.WriteLn here System is name space
//Name spaces group things
//Only a static function can be called without  
// (C) Burhan Saadi Version 1.0.1 For Teaching Purpose only

class NameSpc
{

	private static void Main(string[] args)
	{

		System.Console.WriteLine("Write Line one");
		//NameSpc.ABC(); //It works
		ABC();
		Burhan.YYY.Hello();
	}

	static void ABC()
	{
		System.Console.WriteLine("Function Abc called");
	}

}

namespace Burhan
{

	class YYY
	{
		//Only a public static function can be called 
		//without making an object
		public static void Hello()
		{
			System.Console.WriteLine("Hello World");
		}
	}
}
