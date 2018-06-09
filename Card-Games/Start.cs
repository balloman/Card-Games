using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGames.Games;

namespace CardGames
{
    class Start
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			Blackjack blackjack = new Blackjack();
			blackjack.Enter();
			Console.ReadKey();
			
        }
    }
}
