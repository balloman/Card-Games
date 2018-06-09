using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGames.Utils;

namespace CardGames.Games
{
    class Blackjack : Utils.Game
    {
        public Blackjack(){
            Name = "Blackjack";
            Players = 1;
        }
		protected override void onEnter()
		{
			Card myCard = new Card();
			Console.WriteLine("My card has the name {0}, and the value {1}.", myCard.Name, myCard.Value);
		}
    }
}
