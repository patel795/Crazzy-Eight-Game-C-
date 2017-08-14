using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyEights
{
    public class Player
    {
        //Field Variables
        private string _name;
        private Hand _playerhand;

        //Initializing
        public Player(String name,List<Card> hand)
            
        {
            _name = name;
            _playerhand = new Hand(hand);
        }
        //IN this method,user decides which card to play
        public void Play(Card play)
        {
            List<Card> hand = _playerhand.ListHand();
            this.SearchForMatch(play);
            foreach (Card card in hand)
            {
                if (card.Playable == true)
                {
                    break;
                }
            }
            ///draw a card
            Card drawn = new Card(0,0);
            this.DrawForMatch(drawn,play);
            
            
        }

        public void SearchForMatch(Card play)
        {
            //Search for card which matches the deck
            List<Card> hand = _playerhand.ListHand();
            foreach(Card card in hand)
            {
                
              card.IsPlayable(this.CardMatches(card, play));
                
            }
            
        }

        public void DrawForMatch(Card drawn,Card play)
        {
            //Check for match
            drawn.IsPlayable(this.CardMatches(drawn, play));
            
        }
        //Condition if card matches
        public bool CardMatches(Card card1, Card card2)
        {
            if(card1.Value == card2.Value || card1.Value == 8)
            {
                return true;
            }
            else if (card1.Suit == card2.Suit)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        //Remove a card
        public void RemoveCard(Card card)
        {
            _playerhand.RemoveCard(card);
        }
        //Score
        public int Score()
        {
            return 0;
        }
    }
}

