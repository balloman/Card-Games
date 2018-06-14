using System;
using System.Collections.Generic;

namespace CardGames.Utils {
    public class Hand
    {
        public List<Card> HandList;
        public int HandValue;

        public Hand()
        {
            HandList = new List<Card>();
            HandValue = 0;
        }

        public Hand(List<Card> hand)
        {
            HandList = hand;
            HandValue = 0;
        }

        private int calculateValue() {
            int CurrentScore = 0;
            foreach (Card element in HandList) {
                CurrentScore += element.Value;
            }
            return CurrentScore;
        }

        public void Draw() {
            HandList.Add(new Card());
            HandValue = calculateValue();
        }

        public void ListCards()
        {
            foreach (var element in HandList) {
                Console.Write("{0} of {1}, ", element.Name, element.Suit);
            }
        }
    }
}