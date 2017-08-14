using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyEights
{
    public class Hand
    {
        //Field Variables
        private Deck _deck;
        private List<Card> _hand;

        //Initializing
        public Hand(List<Card> hand)
        {
            _hand = hand;

        }
        //Made a list
        public List<Card> ListHand()
        {
            return _hand;

        }
        //Get method
        public Card GetCard(byte num)
        {
            return _hand[num];

        }
        //To remove card from hand
        public void RemoveCard(Card card)
        {
            _hand.Remove(card);

        }
        //To add card
        public void AddCard(Card card)
        {
            _hand.Add(card);
        }

    }
}
