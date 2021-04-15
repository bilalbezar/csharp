//This program demonstrate some examples regarding the use of
//the precompiler directive and its given below
//==========================================================
#define themark
//You can also undefine with undef
//This makes it easier for us to skip some code etc
#define alpha
#undef alpha
//Following is not possible here
//#define books 100
//==========================================================
class ThePrecompiler
{

public static void Main(string[] args)
{
	#if themark
		System.Console.WriteLine("Inside out");
	#else
		System.Console.WriteLine("Not possible");
	#endif
		

}

}