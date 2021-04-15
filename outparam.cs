class zzz

{

public static void Main()

{

yyy a;

int i=10;

a=new yyy();

a.abc( ref i );

System.Console.WriteLine(i);

}

}

class yyy

{

public void abc( ref int i )

{

System.Console.WriteLine(i);
i= 20 * 20;

}

}
