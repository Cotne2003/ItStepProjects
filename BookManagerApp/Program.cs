using BookManagerApp.Classes;

namespace books
{
	internal class Library
	{
		static void Main(string[] Args)
		{
			Console.WriteLine("Hello this is online library\n");
			bool leave = false;
			Console.WriteLine("Enter any key to go to menu");
			Console.ReadLine();
			Console.Clear();

			List<Book> DBBooks = new List<Book>()
			{
				new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", Published = 1960 },
				new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Published = 1925 },
				new Book { Title = "Pride and Prejudice", Author = "Jane Austen", Published = 1813 },
				new Book { Title = "The Catcher in the Rye", Author = "J.D. Salinger", Published = 1951 },
			};
			while (leave == false)
			{
				Console.WriteLine("Choose your operation\n");
				Console.WriteLine("1. Show all books");
				Console.WriteLine("2. Search book by title");
				Console.WriteLine("3. Add new book");
				Console.WriteLine("4. Leave library");

			

				string title;

				Console.Write("\nEnter your operation number here: ");
				if (int.TryParse(Console.ReadLine(), out int value))
				{
					Console.WriteLine();
					switch (value)
					{
						case 1:
							BookManager.showAllBooks(DBBooks);
							ReturnToMenu();
							break;
						case 2:
							Console.Write("Enter title of book: ");
							title = Console.ReadLine();
							Console.WriteLine();
							BookManager.searchBookByTitle(title, DBBooks);
							ReturnToMenu();
							break;
						case 3:
							try
							{
								Console.Write("Enter title: ");
								title = Console.ReadLine();
								Console.Write("Enter Author: ");
								string author = Console.ReadLine();
								Console.Write("Enter Publish time: ");
								if (int.TryParse(Console.ReadLine(), out int publish))
								{
									Book newBook = BookManager.addNewBook(title, author, publish);
									DBBooks.Add(newBook);
									ReturnToMenu();
								}
								else
								{
									Console.WriteLine("\nPublish year must be in number\n");
									ReturnToMenu();
								}
							}
							catch (ArgumentException e)
							{
								Console.WriteLine($"\n{e.Message}\n");
								ReturnToMenu();
							}
							break;
						case 4:
							leave = true;
							break;
						default:
							Console.WriteLine("Invalid operation");
							ReturnToMenu();
							break;
					}
				}
				else
				{
					Console.Clear();
				}
			}
			void ReturnToMenu()
			{
				Console.WriteLine("Press any key to return to menu");
				Console.ReadLine();
				Console.Clear();
			}
		}
	}
			
}