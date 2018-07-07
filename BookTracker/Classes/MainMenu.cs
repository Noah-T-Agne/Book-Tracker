using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTracker.Classes
{
	public class MainMenu
	{
		public void Display()
		{
			PrintHeader();

			while (true)
			{
				Console.Clear();
				Console.WriteLine();
				Console.WriteLine("Main Menu");
				Console.WriteLine("1] >> Display All Books");
				Console.WriteLine("2] >> Add a Book to the List");
				Console.WriteLine("3] >> Search for a Book");
				Console.WriteLine("Q] >> Quit");

				Console.Write("What option do you want to select? ");
				string input = Console.ReadLine();

				if (input == "1")
				{
					Console.WriteLine("Available Items: ");
					
				}
				else if (input == "2")
				{
					
				}
				else if (input == "Q")
				{
					Console.WriteLine("Quitting");
					break;
				}
				else
				{
					Console.WriteLine("Please try again");
				}
			}
		}

		private void PrintHeader()
		{

			Console.WriteLine("WELCOME!!!!");
		}


	}
}
