//(C) Burhan Saadi Version 1.0.2 For Teaching Purpose only
//Csharp Compileelinker Allows Us To Create Exe, Dll And libs
//Simplest way to generate the dll is 

//============================================================
// COMPILER SWITCHES TO GENERATE THE DLLS
//============================================================
//     csc /t:library thedll.cs (generates thedll.dll)
//     csc /t:library /out:bbb.dll thedll.cs (generates bbb.dll)


//============================================================
//suppose we wanna make a dll of this file
//============================================================
//Note that public is there before that class name that is
//is requierd to be accessed through other program

public class zzz
{

	public void Abc()
	{
		System.Console.WriteLine("Hello");
	}
}

//============================================================