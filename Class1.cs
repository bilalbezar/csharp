using System;

namespace EventHandling
{
	delegate void myDelegate( object sender,YourClass yc );

	class YourClassSource 
	{
		public event myDelegate onNewEvent;
		public void FireEvent()
		{
			onNewEvent( this,new YourClass( 1 ) );
		} //end of FireEvent
	} //end of YourClassSource

	class YourClass: EventArgs
	{
		private int val;
		public YourClass( int v )
		{
			val = v;
		} //end of default constructor

		public int Value
		{
			set 
			{
				val = value;
			} //end of es
			get 
			{
				return val;
			}
		} //end of Value property
	} //end of YourClass

	class Class1
	{
		void onNewEvent( object sender, YourClass yc ) 
		{
			Console.WriteLine( yc.Value.ToString() );
		} //end of onNewEvnet

		[STAThread]
		static void Main(string[] args)
		{         
			YourClassSource ycs = new YourClassSource();
			Class1 cl = new Class1();
			ycs.onNewEvent += new myDelegate( cl.onNewEvent );
			ycs.FireEvent();
		} //end of Main()
	} //end of Class1
} //end of EventHandling namespace
