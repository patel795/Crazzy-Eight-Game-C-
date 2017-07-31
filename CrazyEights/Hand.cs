using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyEights
{
    class Hand
    {
        private Deck _deck;
        private List<Card> _hand;


        public Hand(List<Card> hand)
        {
            _hand = hand;

        }


        public Card GetCard(byte num)
        {
            return _hand[num];

        }

        public void RemoveCard(byte num)
        {
            _hand.RemoveAt(num);

        }
        
        public void AddCard(Card card)
        {
            _hand.Add(card);
        }

    }
}
