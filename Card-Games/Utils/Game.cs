using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGames.Utils
{
    abstract class Game
    {
        public string Name { get; set; }
        public int Players { get; set; }
		public void Enter()
		{
			Console.WriteLine("Starting " + Name + "...");
			onEnter();
		}
		protected abstract void onEnter();
    }
}
