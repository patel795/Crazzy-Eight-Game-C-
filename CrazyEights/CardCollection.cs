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
        private Card _discard;
        private string _label;

        private List<Card> _cardList;

        public CardCollection(string label,Card discard)
        {
            this._label = label;
            this._cardList = new List<Card>();
            this._discard = discard;
        }

        private bool Empty()
        {
            return _cardList.Count == 0;
        }
        private void DecideCardEffects(List<Card> playHand, int userOrComp)
        {
            if (playHand[0].Value == 11)
            {
                SkipTurn(playHand);
            }

            else if(playHand[0].Value == 12)
            {
                PickUpFive(playHand);
            }

            else if(playHand[0].Value == 2)
            {
                PickUpTwo(playHand);
            }
            else if(userOrComp == 1)
            {
                if(playHand[0].Value == 8)
                {
                //UserChangeSuits()
                }
            }
        }
        public int SkipTurn(List<Card> playHand)
        {
            int skip = playHand.Count+1;
            return skip;
        }
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
        public int PickUpTwo(List<Card> playHand)
        {
            int pickUp = playHand.Count*2;
            return pickUp;
        }
        public int CompChangeSuits()
        {
            Random rnd = new Random();
            int randSuit = rnd.Next(1, 5);
            return randSuit;
        }
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
