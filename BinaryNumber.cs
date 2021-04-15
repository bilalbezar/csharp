using System;

namespace NumberSystemConvertor {

	public class BinaryNumber {

		public static void binaryToDecimal() {
			string binary = "";
			double integer=0;
			Console.Write( "Enter Binary Number : " );
			binary = Console.ReadLine();
			for( int index=0; index < binary.Length; index++ ) {
				int binNumber = Int32.Parse( binary.Substring( index,1 ) );
				integer += binNumber * Math.Pow( 2,( binary.Length - ( index + 1 ) ) );
			} //end of for loop
			Console.Write( "Decimal : " + integer );
			Console.WriteLine();
		} //end of binaryToDecimal()
	} //end of BinaryNumber class
} //end of NumberSystemCoverter namespace
