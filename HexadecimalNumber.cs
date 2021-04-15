using System;

namespace NumberSystemConvertor {

	public class HexadecimalNumber {

		public static void hexadecimalToDecimal() {
			string hexadecimal = "";
			double integer=0;
			Console.Write( "Enter Hexadecimal Number : " );
			hexadecimal = Console.ReadLine();
			for( int index=0; index<hexadecimal.Length; index++ ) {
				int hexaNumber = getInteger( hexadecimal.Substring( index,1 ) );
				integer += hexaNumber * Math.Pow( 16,( hexadecimal.Length - ( index + 1 ) ) );
			} //end of for loop
			Console.Write( "Decimal : " + integer );
			Console.WriteLine();
		} //end of hexadecimalTODecimal()

		public static int getInteger( string hexaString ) {
			switch( hexaString ) {
				case "0":
					return 0;
				case "1":
					return 1;
				case "2":
					return 2;
				case "3":
					return 3;
				case "4":
					return 4;
				case "5":
					return 5;
				case "6":
					return 6;
				case "7":
					return 7;
				case "8":
					return 8;
				case "9":
					return 9;
				case "A":
					return 10;
				case "B":
					return 11;
				case "C":
					return 12;
				case "D":
					return 13;
				case "E":
					return 14;
				case "F":
					return 15;
				default:
					return -1;
			} //end of switch statement
		} //end of getInteger()
		
		public static char getCharacter( int integer ) {
			switch( integer ) {
				case 0:
					return '0';
				case 1:
					return '1';
				case 2:
					return '2';
				case 3:
					return '3';
				case 4:
					return '4';
				case 5:
					return '5';
				case 6:
					return '6';
				case 7:
					return '7';
				case 8:
					return '8';
				case 9:
					return '9';
				case 10:
					return 'A';
				case 11:
					return 'B';
				case 12:
					return 'C';
				case 13:
					return 'D';
				case 14:
					return 'E';
				case 15:
					return 'F';
				default:
					return '0';
			} //end of switch statement
		} //end of getCharacter()
	} //end of HexadecimalNumber class
} //end of NumberSystemConverter namespace
