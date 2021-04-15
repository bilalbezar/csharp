//C# Name space name concept 
//Namespaces can be nested
//Since system is used no need to mention it with the console

using System;

class NameSpc
{

	public static void Main(string[] args)
	{
		Console.WriteLine("Write Line one");
		Hello();
		burhan.YYY.Hello();
		burhan.saadi.ZZZ.Hello();
		
	}

	static void Hello()
	{
		System.Console.WriteLine("Hello inside Namespc class");
	}

}


namespace burhan
{
	class YYY
	{
		public static void Hello()
		{
			System.Console.WriteLine("Hello of YYY class");
		}
	}
	//NESTED NAME SPACE or NAMESPACE HIERARCHY
	namespace saadi
	{
		class ZZZ
		{
			public static void Hello()
			{
				System.Console.WriteLine("Hello of Zzz class");
			}
		}

	}
}