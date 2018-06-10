using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CardGames.Utils;

namespace CardGames.Games
{
	//inherits from my game class
    class Blackjack : Utils.Game
    {
		//Create a list of cards that is a hand, these work like arrays
		public List<Card> Hand = new List<Card>();
		public int CurrentScore;

		//constructor that sets the name and number of players as required in the game class
        public Blackjack(){
            Name = "Blackjack";
            Players = 1;
			CurrentScore = 0;
		}


		private void HandLogic()
		{
			Console.WriteLine("Current Hand =");
			CurrentScore = 0;
			//iterates over the hand and adds up the total
			foreach (Card element in Hand)
			{
				Console.Write("{0} of {1}, ", element.Name, element.Suit);
				CurrentScore += element.Value;
			}
			Console.WriteLine("Current Score of {0}", CurrentScore);
			Thread.Sleep(2000);
			Console.WriteLine("Would you like to Hit or Stay?");
			Console.WriteLine("Press H to hit, and any other key to stay...");
			
		}

		//overridden function from Game class
		protected override void OnEnter()
		{
			Hand.Add(new Card());
			while (true)
			{
				HandLogic();
				if (Console.ReadKey().Key == ConsoleKey.H)
				{
					Console.WriteLine();
					Hit();
				}
				else
				{
					Console.WriteLine();
					EndGame();
					break;
				}
				Console.WriteLine();
			}
		}

		private void Hit()
		{
			//Adds a new card to the hand
			Hand.Add(new Card());
		}

		protected override void EndGame()
		{
			Console.WriteLine("Final score of {0}",this.CurrentScore);
		}
    }
}
