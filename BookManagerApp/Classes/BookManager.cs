namespace BookManagerApp.Classes
{
	internal class BookManager
	{
		public static Book addNewBook(string title, string author, int published)
		{
			if (title.Length == 0 || author.Length == 0)
			{
				throw new ArgumentException("Title or author must be entered");
			}
			else
			{
				Console.WriteLine("\nNew book added successfully\n");
				return new Book { Title = title, Author = author, Published = published };
			}
		}
		public static void showAllBooks(List<Book> books)
		{
			for (int i = 0; i < books.Count; i++)
			{
				Console.WriteLine($"{i + 1}: {books[i].Title}");
				Console.WriteLine($"Author: {books[i].Author}");
				Console.WriteLine($"Published: {books[i].Published}");
				Console.WriteLine();
			}
		}
		public static void searchBookByTitle(string title, List<Book> books)
		{
			Book? searchedBook = books.Find((b) => title.ToLower().Equals(b.Title.ToLower()));
			if (searchedBook != null)
			{
				Console.WriteLine($"Title: {searchedBook.Title}");
				Console.WriteLine($"Author: {searchedBook.Author}");
				Console.WriteLine($"Published: {searchedBook.Published}");
			}
			else
			{
				Console.WriteLine($"No book found with this title: {title}");
			}
		}
	}
}
