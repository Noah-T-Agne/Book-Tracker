using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookTracker.Classes;
using System.IO;

namespace BookTracker
{
	public class Program
	{
		static void Main(string[] args)
		{

			BookTrackerCLI cli = new BookTrackerCLI();
			cli.RunCLI();

		}


		/// <summary>
		/// Allows user to search for books read during certain month
		/// </summary>
		/// <param name="books"></param>
		//public static void SearchByMonth(List<Book> books)
		//{
		//	Console.WriteLine("Please enter the month you would like to look at: ");
		//	string month = Console.ReadLine().ToUpper();
		//	for (int i = 0; i < books.Count; i++)
		//	{
		//		if (books[i].MonthYearRead.ToUpper() == month)
		//			Console.WriteLine($"{books[i].Title} by {books[i].Author}");
		//	}
		//}


		//private static List<string> GetBooksFromFile(string inputPath)
		//{
		//	List<string> listOfBooks = new List<string>();
		//	inputPath = Path.Combine(Environment.CurrentDirectory, "BookList.txt");

		//	try
		//	{

		//		using (StreamReader sr = new StreamReader(inputPath))
		//		{
		//			while (!sr.EndOfStream)
		//			{
		//				string line = sr.ReadLine();
		//				listOfBooks.Add(line);

		//			}
		//		}
		//	}
		//	catch (IOException ex)
		//	{
		//		Console.WriteLine(ex.Message);
		//	}

		//	return listOfBooks;
		//}

		//public static List<Book> CleanBookInfo(List<string> listOfBooks)
		//{
		//	List<Book> goodBooks = new List<Book>();
		//	foreach (var book in listOfBooks)
		//	{
		//		string[] splitString = book.Split('|');
		//		goodBooks.Add(new Book(splitString[0], splitString[1], splitString[2], splitString[3], splitString[4]));

		//	}
		//	return goodBooks;

		//}

	}
}
