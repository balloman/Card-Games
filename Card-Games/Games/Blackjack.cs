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
        private Hand PlayerHand = new Hand();
        private Hand CasinoHand = new Hand();

		//constructor that sets the name and number of players as required in the game class
        public Blackjack(){
            Name = "Blackjack";
            Players = 1;
		}

        private void CheckHand()
        {
            if (PlayerHand.HandValue == 21) {
                Console.WriteLine("BLACKJACK!!");
                Thread.Sleep(1000);
                Console.WriteLine("Congratulations");
                EndGame();
            } else if (PlayerHand.HandValue > 21) {
                Console.WriteLine("Busted...");
                while (CasinoPlay()) {
                    Console.WriteLine("Casino is playing...");
                    Thread.Sleep(750);
                }
                EndGame();
            }
        }

        private void Input()
        {
            
            Console.WriteLine("Would you like to Hit or Stay?");
            Console.WriteLine("Press H to hit, and any other key to stay...");
        }


		private void HandLogic()
		{
			Console.WriteLine("Current Hand =");
            PlayerHand.ListCards();
			//iterates over the hand and adds up the total
			Console.WriteLine("Current Score of {0}", PlayerHand.HandValue);
			Thread.Sleep(1000);
		}

        private bool CasinoPlay()
        {
            if (CasinoHand.HandValue < 17) {
                CasinoHand.Draw();
                return true;
            } else {
                return false;
            }
        }

		//overridden function from Game class
		protected override void OnEnter()
		{
			PlayerHand.Draw();
            CasinoHand.Draw();
			while (!EndOfGame)
			{
				HandLogic();
                CheckHand();
				Console.WriteLine();
                if (!EndOfGame) {
					Input();
					if (Console.ReadKey().Key == ConsoleKey.H) {
                        Console.WriteLine();
                        PlayerHand.Draw();
                    } else {
                        Console.WriteLine();
                        while (CasinoPlay()) {
                            Console.WriteLine("Casino is playing...");
                            Thread.Sleep(750);
                        }
                        EndGame();
                        break;
                    }
                }
                CasinoPlay();
				Console.WriteLine();
			}
		}

		protected override void EndGame()
		{
			Console.WriteLine("Final score of {0}",PlayerHand.HandValue);
            Console.WriteLine("Casino had a score of {0}", CasinoHand.HandValue);
            EndOfGame = true;
            if (((PlayerHand.HandValue > CasinoHand.HandValue) || (CasinoHand.HandValue > 21)) && (PlayerHand.HandValue <=21)) {
                Console.WriteLine("You Win!");
            }else if (PlayerHand.HandValue == CasinoHand.HandValue) {
                Console.WriteLine("It's a tie!");
            } else {
                Console.WriteLine("You Lose...");
            }
		}
    }
}
