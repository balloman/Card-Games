using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGames.Games;
using CardGames.Utils;

namespace CardGames
{
    class Start
    {
        static void Main(string[] args)
		{
			var games = Utilities.ConfigUtilities.GetGames();
			Console.WriteLine("Welcome to the Card Games Portal");
			Console.WriteLine("Please choose a game");
			int count = 1;
			foreach (var item in games)
			{
				Console.WriteLine("{0}. {1}", count, item.Name);
				count++;
			}
			bool correctChoice = false;
			while (!correctChoice)
			{
				if (Console.ReadKey().Key == ConsoleKey.D1)
				{
					Console.WriteLine();
					Blackjack blackjack = new Blackjack();
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
