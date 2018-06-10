using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGames.Utils
{
	/*abstract means that this is like a derivative of a class
	 The idea is that I can make an idea for a class, with variables and stuff
	 but you can't actually instantiate this class, you can only make classes that inherit it.
	 This makes it more modular and prevents someone from accidentally trying to make a game object
	 */
    abstract class Game
    {
		/*Make a property of a game called its name
		 The reason we have get and set is basically just a formality for class variables
		 they have no use now, but in the future it allows you to control how someone changes 
		 the variable instead of just trying to set a value to it or read it.
			 */
        public string Name { get; set; }
        public int Players { get; set; }
		/* This class actually starts the game
		 */
		public void Enter()
		{
			Console.WriteLine("Starting " + Name + "...");
			//Run the method the game has made to start itself.
			OnEnter();
		}
		//this is an abstract method, what it does is it forces anyone who makes a game that inherits this class to create the method
		//What this means is that if i make a poker game that inherits this class, it must have an OnEnter method and an EndGame method
		protected abstract void OnEnter();
		protected abstract void EndGame();
    }
}
