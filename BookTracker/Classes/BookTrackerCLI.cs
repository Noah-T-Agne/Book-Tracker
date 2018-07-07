using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookTracker.DAL;

namespace BookTracker.Classes
{
	public class BookTrackerCLI
	{
		const string Command_AddBook = "2";
		const string Command_DisplayAllBooks = "1";
		//const string Command_ViewAllSeries = "2";
		//const string Command_AddSeries = "4";
		//const string Command_DisplayBookByMonth = "5";
		//const string Command_DisplayBookByAuthor = "6";
		const string Command_Quit = "q";

		const string DatabaseConnection = @"Data Source=.\SQLEXPRESS;Initial Catalog=BookTracker;Integrated Security=True";

		public void RunCLI()
		{
			//PrintHeader();
			PrintMenu();

			while (true)
			{
				//Book book = new Book();

				//book.Title = Console.ReadLine();

				string command = Console.ReadLine();

				Console.Clear();

				switch (command.ToLower())
				{
					case Command_DisplayAllBooks:
						DisplayAllBooks();
						break;

					//case Command_ViewAllSeries:
					//    GetSeriesNames();
					//    break;

					case Command_AddBook:
						AddNewBook();
						break;

					//case Command_AddSeries:
					//    AddNewSeries();
					//    break;

					//case Command_DisplayBookByMonth:
					//    GetBookByMonth();
					//    break;

					//case Command_DisplayBookByAuthor:
					//    GetBookByAuthor();
					//    break;

					case Command_Quit:
						Console.WriteLine("Thank you and Happy Reading!");
						return;

					default:
						Console.WriteLine("The command provided was not a valid command, please try again.");
						break;
				}

				Console.ReadKey();
			}
		}

		private void DisplayAllBooks()
		{
			while (true)
			{
				BookSqlDAL dal = new BookSqlDAL(DatabaseConnection);
				IList<Book> books = dal.GetBooks();

				if (books.Count > 0)
				{
					foreach (var book in books)
					{
						Console.WriteLine();
						Console.WriteLine("Title -- " + book.Title);
						Console.WriteLine("Author -- " + book.Author.PadRight(20) + ("Publish Year -- " + book.PublishYear.ToString().PadRight(7)) + ("Page Count -- " + book.PageCount));

					}
				}
				else
				{
					Console.WriteLine("***** NO RESULTS *****");
				}




				Console.WriteLine();
				Console.Write("Enter (Q) to return to Main Menu: >>> ");
				string menuBack = Console.ReadLine().ToUpper();
				if (menuBack == "Q")
				{
					break;
				}
				Console.Clear();
			}

			Console.Clear();
			PrintMenu();
		}
		private void AddNewBook()
		{
			Book book = new Book();
			Console.WriteLine("Please enter title of new book: ");
			Console.Write(">>> ");
			book.Title = Console.ReadLine();

			Console.WriteLine("Please enter Author of new book: ");
			Console.Write(">>> ");
			book.Author = Console.ReadLine();

			Console.WriteLine("Please enter publish year of new book: ");
			Console.Write(">>> ");
			book.PublishYear = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Please enter # of pages in new book: ");
			Console.Write(">>> ");
			book.PageCount = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Please enter Month when book was read: ");
			Console.Write(">>> ");
			book.MonthRead = (Console.ReadLine());



			BookSqlDAL dal = new BookSqlDAL(DatabaseConnection);
			int id = dal.AddBook(book);

			if (id > 0)
			{
				Console.WriteLine("*** SUCCESS ***");
			}
			else
			{
				Console.WriteLine("*** DID NOT ADD ***");
			}

			PrintMenu();
		}

		//private void GetSeriesNames()
		//{
		//	throw new NotImplementedException();
		//}


		//private void PrintHeader()
		//      {
		//          Console.WriteLine(@" _    _  _____ ______  _     ______     ______   ___   _____   ___  ______   ___   _____  _____ ");
		//          Console.WriteLine(@"| |  | ||  _  || ___ \| |    |  _  \    |  _  \ / _ \ |_   _| / _ \ | ___ \ / _ \ /  ___||  ___|");
		//          Console.WriteLine(@"| |  | || | | || |_/ /| |    | | | |    | | | |/ /_\ \  | |  / /_\ \| |_/ // /_\ \\ `--. | |__  ");
		//          Console.WriteLine(@"| |/\| || | | ||    / | |    | | | |    | | | ||  _  |  | |  |  _  || ___ \|  _  | `--. \|  __| ");
		//          Console.WriteLine(@"\  /\  /\ \_/ /| |\ \ | |____| |/ /     | |/ / | | | |  | |  | | | || |_/ /| | | |/\__/ /| |___ ");
		//          Console.WriteLine(@" \/  \/  \___/ \_| \_|\_____/|___/      |___/  \_| |_/  \_/  \_| |_/\____/ \_| |_/\____/ \____/ ");
		//      }



		private void PrintMenu()
		{
			Console.WriteLine();
			Console.WriteLine("Please Select an Option Below");
			Console.WriteLine();
			Console.WriteLine(" 1 - Get a list of all of the Books");
			Console.WriteLine(" 2 - Add a new Book");
			Console.WriteLine(" Q - Quit");
		}

	}
}
