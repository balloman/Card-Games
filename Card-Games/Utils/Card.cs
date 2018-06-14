using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CardGames.Utils
{
	public class Card
	{
		private static Dictionary<string, int> CardValues = new Dictionary<string, int>()
		{
			{"A", 1},
			{"2", 2},
			{"3", 3},
			{"4", 4},
			{"5", 5},
			{"6", 6},
			{"7", 7},
			{"8", 8},
			{"9", 9},
			{"10", 10},
			{"J", 10},
			{"Q", 10},
			{"K", 10}
		};
		private static string[] SuitsList = new string[] { "Clubs", "Spades", "Diamonds", "Hearts" };

		public string Name;
		public int Value;
		public string Suit;
		public Card()
		{
			RNG random = new RNG();
			int seed1 = random.RandInt(CardValues.Count);
			int seed2 = random.RandInt(SuitsList.Count<string>());
			Name = CardValues.Keys.ElementAt<string>(seed1);
			Value = CardValues[Name];
			Suit = SuitsList[seed2];
		}
	}

}
