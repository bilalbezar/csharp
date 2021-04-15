using System;

namespace NumberSystemConvertor {

	public class OctalNumber {

		public static void octalToDecimal() {
			string octal = "";
			double integer=0;
			Console.Write( "Enter Octal Number : " );
			octal = Console.ReadLine();
			for( int index=0; index < octal.Length; index++ ) 
			{
				int octNumber = Int32.Parse( octal.Substring( index,1 ) );
				integer += octNumber * Math.Pow( 8,( octal.Length - ( index + 1 ) ) );
			} //end of for loop
			Console.Write( "Decimal : " + integer );
			Console.WriteLine();
		} //end of octalToDecimal()

	} //end of OctalNumber class
} //end of NumberSystemConverter namespace
