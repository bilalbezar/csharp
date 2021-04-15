using System;

namespace structExample
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	/// 
	public struct Subscriber{
	
	public long ID;
	public string firstName;
	}
	class Class1
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Subscriber x=new Subscriber();
			Subscriber y;
			x.ID=100;
			x.firstName="Aslam";
			y.ID=101;
			y.firstName="Asad";
			Console.WriteLine(x.ID);
			Console.WriteLine(x.firstName);
			Console.WriteLine(y.ID);
			Console.WriteLine(y.firstName);
			Console.ReadLine();
		}
	}
}
