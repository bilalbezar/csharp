using System;

namespace MyNameSpace {

	public class JavaBook: Book {

		private string title;
		private string author;
		private int price;
		private int pages;

		private JavaBook() {
			title = "Java2 Complete Refference";
			author = "Herbert Schildt";
			price = 150;
			pages = 985;										  
		} //end of JavaBook()

		public static JavaBook getJavaBook() {
			return new JavaBook();
		} //end of getJavaBook()

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

	} //end of JavaBook class
} //end of MyNameSpace
