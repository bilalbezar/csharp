using System;

namespace ConsoleApplication1
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Class1
	{
		enum Temperatures{
			
			WickedCold=0,
			FreezingPoint=32,
			LightJacketWeather=60,
			swimmingweather=72,
			BoilingPoint=212
		
		}
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		/// 
		[STAThread]
		static void Main(string[] args)
		{
			//
			// TODO: Add code to start application here
			//
			Console.WriteLine("Hello World!");
			int a=5;
			int b=4;
			int c=a+b;
			Console.WriteLine("c="+c);
			Console.WriteLine("Boiling Point="+(int)Temperatures.BoilingPoint);
			Console.ReadLine();
			
		}
	}
}
