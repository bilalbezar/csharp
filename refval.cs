// CSharp can send variables either as ref or as value


class zzz
{
	 static void Main(string[] args)
	{
		int i = 1;
		//Sending as a vale
		ByValue(i);
		System.Console.WriteLine(i);
		//Sending as a Ref
		Byout(out i);
		System.Console.WriteLine(i);
		Byref(ref i);
		System.Console.WriteLine(i);
	}

	static void ByValue(int j)
	{
		j++;
	}

	static void Byout(out int i)
	{
		//you can not use main's value here like this
		//We can simply change the value only
		//System.Console.WriteLine(i);
		i = 100;
	}

	static void Byref(ref int i)
	{
		System.Console.WriteLine(i);
		i++;		
	}
}

