using System;

namespace MyNameSpace {

	public class CppBook: Book {

		private string title;
		private string author;
		private int price;
		private int pages;

		private CppBook() {
			title = "Beginning C++";
			author = "Ivor Horton";
			price = 170;
			pages = 678;										  
		} //end of CppBook()

		public static CppBook getCppBook() {
			return new CppBook();
		} //end of getCppBook()

		public string getBookAuthor() {
			return author;
		} //end of getBookAuthor()

		public string getBookTitle() {
			return title;
		} //end of BookTitle() 

		public int getBookPrice() {
			return price;
		} //end of getBookPrice()
			
		public int getBookPages() {
			return pages;
		} //end of getBookPages

		public override string ToString() {
			return "Book Title : " + title + "\nBook Author : " + 
				author + "\nPrice : " + price + "\nPages : " + pages + "\n";
		} //end of ToString()
	} //end of CppBook class
} //end of MyNmaeSpace namcepace
