using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTracker.Classes
{
	 public class Book
	{
		/// <summary>
		/// Number to represent the book.
		/// </summary>
		public int BookId { get; set; }

		/// <summary>
		/// Name of the book.
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// name of writer of book
		/// </summary>
		public string Author { get; set; }


		/// <summary>
		/// Year that the book was published.
		/// </summary>
		public int PublishYear { get; set; }

		/// <summary>
		/// Month and year that the book was read.
		/// </summary>
		public string MonthRead { get; set; }

		/// <summary>
		/// Number of pages in the book.
		/// </summary>
		public int PageCount { get; set; }  


		
		public Book(string title,string author, int publishYear, string monthRead, int pageCount)
		{
			
			this.Title = title;
			this.PublishYear = publishYear;
			this.MonthRead = monthRead;
			this.PageCount = pageCount;
			this.Author = author;

		}

		public Book()
		{ }

	}
}
