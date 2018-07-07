using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookTracker.Classes;

namespace BookTracker.DAL
{
	public class BookSqlDAL
	{
		private string connectionString;
		public BookSqlDAL(string dbConnectionString)
		{
			connectionString = dbConnectionString;
		}


		public IList<Book> GetBooks()
		{
			List<Book> books = new List<Book>();
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();

					SqlCommand cmd = new SqlCommand("SELECT * FROM books_2018;", conn);
					SqlDataReader reader = cmd.ExecuteReader();

					while (reader.Read())
					{
						Book book = new Book();
						book.BookId = Convert.ToInt32(reader["id"]);
						book.Title = Convert.ToString(reader["title"]);
						book.PageCount = Convert.ToInt32(reader["pages"]);
						book.PublishYear = Convert.ToInt32(reader["pub_year"]);
						book.Author = Convert.ToString(reader["author_name"]);

						books.Add(book);

					}
				}
			}
			catch(SqlException ex)
			{
				Console.WriteLine(ex.Message);
			}
			return books;
		}
		public int AddBook(Book newBook)
		{
			int rowsAffected = 0;

			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();

					SqlCommand cmd = new SqlCommand("INSERT INTO books_2018 (title, author_name, pub_year, pages, month_read) VALUES (@title,@author_name, @pub_year, @pages, @month_read);", conn);
					cmd.Parameters.AddWithValue("@title", newBook.Title);
					cmd.Parameters.AddWithValue("@pub_year", newBook.PublishYear);
					cmd.Parameters.AddWithValue("@pages", newBook.PageCount);
					cmd.Parameters.AddWithValue("@author_name", newBook.Author);
					cmd.Parameters.AddWithValue("@month_read", newBook.MonthRead);

					rowsAffected = cmd.ExecuteNonQuery();
				}
			}
			catch(SqlException ex)
			{
				Console.WriteLine(ex.Message);
			}
			return rowsAffected;
		}
	}
}
