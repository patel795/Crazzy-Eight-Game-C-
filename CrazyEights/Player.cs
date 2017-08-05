using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyEights
{
    public class Player
    {
        private string _name;
       


        public Player(String name,List<Card> hand)
            
        {
            _name = name;
            Hand playerhand = new Hand(hand);
        }

        public Card Play(CardGame cardGame)
        {
            return null;
        }

        public Card SearchForMatch(Card prev)
        {
            return null;
        }

        public Card DrawForMatch(CardGame cardGame, Card prev)
        {
            return null;
        }

        public bool CardMatches(Card card1, Card card2)
        {
            return true;
        }
        public int Score()
        {
            return 0;
        }
    }
}

