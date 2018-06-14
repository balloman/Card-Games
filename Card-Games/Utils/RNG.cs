using System;
using System.Linq;


namespace CardGames.Utils
{
    public class RNG
    {
        public static int[] numArray = new int[5]{1, 2, 3, 4, 5};
        private static int count = 0;
        public int RandInt()
        {
            Random random = new Random((int)DateTime.Now.Ticks & 0x0000FFFF * numArray[count%5]);
            count++;
            return random.Next();
        }
        public int RandInt(int range)
        {
            Random random = new Random((int)(DateTime.Now.Ticks & 0x0000FFFF) * numArray[count%5]);
            count++;
            return random.Next(range);
        }
    }
}