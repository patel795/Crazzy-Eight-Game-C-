using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyEights
{
    public class CardGame
    {
        private Player one;
        private Player two;
        private Hand drawPile;
        private Hand discardPile;


        public CardGame()
        {
            //Deck deck = new Deck("Deck");
            //deck.ShuffleCards();

            //int handSize = 8;
            //one = new Player("John");
            //deck.deal(one.getHand(), handSize);

            //two = new Player("Chris");
            //deck.deal(two.getHand(), handSize);

            //discardPile = new Hand("Discards");
            //deck.deal(discardPile, 1);

            //drawPile = new Hand("Draw pile");
            //deck.dealAll(drawPile);
        }
        public bool IsDone()
        {
            return true;
        }
    }




}
