using System;

namespace MyNameSpace {

	public class CsBook: Book {
		private string title;
		private string author;
		private int price;
		private int pages;

		private CsBook() {
			title = "Beginning C#";
			author = "Karli Watson";
			price = 140;
			pages = 1030;										  
		} //end of CsBook()

		public static CsBook getCsBook() {
			return new CsBook();
		} //end of getCsBook()

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
	} //end of CsBook class
} //end of MyNmaeSpace namespace
