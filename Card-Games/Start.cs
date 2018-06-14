using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
			
			while (true)
			{
				Thread.Sleep(4000);
				Console.Write("\n\n\n");
				Console.WriteLine("Please choose a game or press Q to quit");
				int count = 1;
				//Lists all of the games
				foreach (var item in games) {
					//Similar to print("%d. %s") % (count, item.Name) in python
					Console.WriteLine("{0}. {1}", count, item.Name);
					count++;
				}
				ConsoleKey keyPressed = Console.ReadKey().Key;
				if (keyPressed == ConsoleKey.D1)
				{
					Console.WriteLine();
					//Creates a new blackjack game
					Blackjack blackjack = new Blackjack();
					//Start the game
					blackjack.Enter();
				}else if (keyPressed == ConsoleKey.Q) {
					Console.WriteLine();
					Console.Write("Exiting");
					Thread.Sleep(1000);
					break;
				}
				else
				{
					Console.WriteLine(" Not a recognized game...");
				}
			}
			
        }
    }
}
