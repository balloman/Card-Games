using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Import my games folder
using CardGames.Games;
//import my utils folder
using CardGames.Utils;

namespace CardGames
{
    class Start
    {
		/*The static simply means that it shouldn't be run every time the object is created
		 This is so I can run this without having to create a Start object beforehand
		 Void means don't return anything
			 */
        static void Main(string[] args)
		{
			//This creates a variable which holds the list of games from the config file*
			var games = Utilities.ConfigUtilities.GetGames();
			Console.WriteLine("Welcome to the Card Games Portal");
			Console.WriteLine("Please choose a game");
			int count = 1;
			//Lists all of the games
			foreach (var item in games)
			{
				//Similar to print("%d. %s") % (count, item.Name) in python
				Console.WriteLine("{0}. {1}", count, item.Name);
				count++;
			}
			bool correctChoice = false;
			while (!correctChoice)
			{
				if (Console.ReadKey().Key == ConsoleKey.D1)
				{
					Console.WriteLine();
					//Creates a new blackjack game
					Blackjack blackjack = new Blackjack();
					//Start the game
					blackjack.Enter();
					correctChoice = true;
				}
				else
				{
					Console.WriteLine(" Not a recognized game...");
					correctChoice = false;
				}
			}
			Console.ReadKey();
			
        }
    }
}
