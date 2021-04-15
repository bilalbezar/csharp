using System;

namespace NumberSystemConvertor {

	public class DecimalNumber {

		public static void decimalToBinary() {
			int integer = 0;
			string binaryNumber = "";
			try {
				do {
					Console.Write( "Enter A Decimal : " );
					integer = Int32.Parse( Console.ReadLine() );
				} while( integer<0 );
				while( integer>1 ) {
					binaryNumber += ( integer % 2 );
					integer /= 2;
				} //end of while loop
				if( integer>0 )  {
					binaryNumber += integer;
				} //end of if statement
				Console.Write( "Binary Number : " );
				for( int bn=binaryNumber.Length; bn>0 ;bn-- ) {
					Console.Write( binaryNumber.Substring( bn-1,1) );
				} //end of for loop
				Console.WriteLine();
			} catch( Exception exception ) {
				Console.WriteLine( "Invalid Input" );
			} //end of try catch block
		} //end of DecimalToBinary()
		public static void decimalToOctal() {
			int integer = 0;
			string binaryNumber = "";
			try {
				do {
					Console.Write( "Enter A Decimal : " );
					integer = Int32.Parse( Console.ReadLine() );
				} while( integer<0 );
				while( integer>1 ) {
					binaryNumber += ( integer % 8 );
					integer /= 8;
				} //end of while loop
				if( integer>0 ) {
					binaryNumber += integer;
				} //end of if statement
				Console.Write( "Octal Number : " );
				for( int bn=binaryNumber.Length; bn>0 ;bn-- ) {
					Console.Write( binaryNumber.Substring( bn-1,1) );
				} //end of for loop
				Console.WriteLine();
			} catch( Exception exception ) {
				Console.WriteLine( "Invalid Input" );
			} //end of try catch block
		} //end of DecimalToOctal()
		public static void decimalToHexadecimal() {
			int integer = 0;
			string binaryNumber = "";
			try {
				do {
					Console.Write( "Enter A Decimal : " );
					integer = Int32.Parse( Console.ReadLine() );
				} while( integer<0 );
				while( integer>1 ) {
					binaryNumber += HexadecimalNumber.getCharacter(( integer % 16 ) );
					integer /= 16;
				} //end of while loop
				if( integer>0 ) {
					binaryNumber += HexadecimalNumber.getCharacter( integer );
				} //end of if statement
				Console.Write( "Octal Number : " );
				for( int bn=binaryNumber.Length; bn>0 ;bn-- ) {
					Console.Write( binaryNumber.Substring( bn-1,1) );
				} //end of for loop
				Console.WriteLine();
			} catch( Exception exception ) {
				Console.WriteLine( "Invalid Input" );
			} //end of try catch block
		} //end of decimalToHexadecimal()
	} //end of DecimalNumber class
}
