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
        private void DecideCardEffects(List<Card> playHand)
        {
            if (playHand[0].Value == 11)
            {
                if (playHand.Count > 1)
                {
                    foreach (Card card in playHand)
                    {
                        //Skip += 1
                        //return skip
                    }
                }
            }

            else if(playHand[0].Value == 12)
            {
                foreach(Card card in playHand)
                {
                    if(card.SuitName == "Spades")
                    {
                        //retuurn pick up 5 cards
                    }
                }
                //return do nothing
            }

            else if(playHand[0].Value == 2)
            {
                //addcard = 0
                foreach(Card card in playHand)
                {
                    //addcard += 2
                }
                //return addcard
            }

            else if(playHand[0].Value == 8)
            {
                //ask
            }
        }

    }
}
