using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace CrazyEights
{
    public class CardCollection 
    {
        //Defining Field Variables
        private Card _discard;
        private string _label;

        private List<Card> _cardList;
        //Initialization
        public CardCollection(string label,Card discard)
        {
            this._label = label;
            this._cardList = new List<Card>();
            this._discard = discard;
        }
        //Returns when cards are zero
        private bool Empty()
        {
            return _cardList.Count == 0;
        }
        private void DecideCardEffects(List<Card> playHand, int userOrComp)
        {
            //Player skips the turn
            if (playHand[0].Value == 11)
            {
                SkipTurn(playHand);
            }

            //Player picks up 5 cards on spades of queen
            else if(playHand[0].Value == 12)
            {
                PickUpFive(playHand);
            }

            //Player picks up 2 cards on 2
            else if(playHand[0].Value == 2)
            {
                PickUpTwo(playHand);
            }
            //Player can change the colour of the suit
            else if(userOrComp == 1)
            {
                if(playHand[0].Value == 8)
                {
                //UserChangeSuits()
                }
            }
        }
        //Skips the turn
        public int SkipTurn(List<Card> playHand)
        {
            int skip = playHand.Count+1;
            return skip;
        }
        //Pick up 5 cards
        public int PickUpFive(List<Card> playHand)
        {
            int pickUp = 0;
            foreach (Card card in playHand)
            {
                if (card.SuitName == "Spades")
                {
                    return pickUp += 5;
                }
            }
            return pickUp;
        }

        //Pick up 2 cards
        public int PickUpTwo(List<Card> playHand)
        {
            int pickUp = playHand.Count*2;
            return pickUp;
        }
        //Computer changes suit
        public int CompChangeSuits()
        {
            Random rnd = new Random();
            int randSuit = rnd.Next(1, 5);
            return randSuit;
        }
        //User can change suit
        public int UserChangeSuits(string suit)
        {
            if (suit == "Diamonds")
            {
                return 1;
            }
            else if (suit == "Clubs")
            {
                return 2;
            }
            else if (suit == "Hearts")
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }
    }
}
