//producing warning and errors at compilation time
//Why do we need that?
//consider the following example if something is not defined


#define TRYIT
#define DOIT

class warnerror
{


public static void Main(void)
{
	#if TRYIT && DOIT
		//A user defined warning
		#warning a test of warning
	#endif

	#if GK
		System.Console.WriteLine("Hello");
	#else
		//A user defined error
		#error Stop the compilation here
	#endif

}

}