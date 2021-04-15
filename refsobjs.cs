//use of a refrence as a pointer to an array


class refobjs
{
	//========================================================
	public static void Main(string[] args)
	{
		System.Console.WriteLine("This object refrence things");
		System.Console.WriteLine("===========================");
		object[] b = {1,"ddfg",344.55};
		object c = b;
		afunction(b);
		afunction(c);
				
		
	}
	//========================================================
	public static void afunction(params object[] b)
	{
		//Just tesing the effects of things
		foreach(object o in b)
	  		System.Console.WriteLine(o.GetType().FullName+" ");
	}
	//========================================================
}