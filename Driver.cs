using System;

namespace NumberSystemConvertor
{
	class Driver
	{
		[STAThread]
		static void Main(string[] args)
		{
			int choice = -1;
			while( choice!=7 ) 
			{
				Console.WriteLine( "Options" );
				Console.WriteLine( "1.  Decimal To Binary" );
				Console.WriteLine( "2.  Binary To Decimal" );
				Console.WriteLine( "3.  Decimal To Octal" );
				Console.WriteLine( "4.  Octal To Decimal" );
				Console.WriteLine( "5.  Decimal To Hexadecimal" );
				Console.WriteLine( "6.  Hexadecimal To Decimal" );
				Console.WriteLine( "7.  Quit" );
				do {
					try {
						Console.Write( "Enter Choice : " );
						choice = Int32.Parse( Console.ReadLine() );
					} 
					catch( Exception e ) {
						Console.WriteLine( "Invalid Input" );
					} //end of try catch block
				}while( choice<1 || choice>7 );
				switch( choice )
				{
					case 1:
						DecimalNumber.decimalToBinary();
						break;
					case 2:
						BinaryNumber.binaryToDecimal();
						break;
					case 3:
						DecimalNumber.decimalToOctal();
						break;
					case 4:
						OctalNumber.octalToDecimal();
						break;
					case 5:
						DecimalNumber.decimalToHexadecimal();
						break;
					case 6:
						HexadecimalNumber.hexadecimalToDecimal();
						break;
				} //end of switch statement
			} //end of while loop
		}
	}
}
