using System;

namespace MyNameSpace {

	public class BookManager {
		
		public static Book getBook( string url ) {
			switch( url ) {
				case "book.java":
					return JavaBook.getJavaBook();
				case "book.c++":
					return CppBook.getCppBook();
				case "book.c#":
					return CsBook.getCsBook();
				default:
					return null;
			} //end of switch statement
		} //end of getBook()

	} //end of BookManager class
} //end of MyNameSpace namespace
