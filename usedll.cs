//(C) Burhan Saadi Version 1.0.2 For Teaching Purpose only
//After Creating a dll we may need to use it in a C# program
//To use dll generated in the C# we need following

//==========================================================
//The Command line is here to link our exe and ask it to 
//look at dll is given below
//==========================================================
//csc /r:thedll1.dll usedll.cs

//because test dll uses the wrapper
using testdll;

class usethedll
{
    //You need to create an object if you wanna access not 
    //static member function
    
    yyy obj;
    
    public static void Main(string[] args)
    {
    	zzz a = new zzz();
    	a.Abc();
    	//Object is required to use the non-static things
    	usethedll x = new usethedll();
    	x.another();
    	System.Console.WriteLine("Hello World 2002");
    }
    
    public void another()
    {
    	obj = new yyy();
    	obj.Function1();
    }
    
}

//==========================================================
//So it finally works with a dll    	
//==========================================================
