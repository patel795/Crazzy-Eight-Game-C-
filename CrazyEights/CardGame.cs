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
        private AIComputer comp1;
        private AIComputer comp2;
        private AIComputer comp3;
        private List<Card> drawPile;
        private List<Card> discardPile;
        private Card prev;


        public CardGame()
        {
            //int handSize = 8;
            //Deck deck = new Deck("Deck");
            //deck.ShuffleCards();

            //user = new Player("Player");
            //deck.deal(user.GetHand(), handSize);

            //comp1 = new AiComputer("Computer 1");
            //deck.deal(comp1.GetHand(), handSize);

            //comp2 = new AiComputer("Computer 2");
            //deck.deal(comp2.GetHand(), handSize);

            //comp3 = new AiComputer("Computer 3");
            //deck.deal(comp3.GetHand(), handSize);

            // discardPile = new Hand("Discards");
            // deck.deal(discardPile, 1);

            // drawPile = new Hand("DrawPile");
            //deck.dealAll(drawPile)

            //win = true
            //While(win = true)
              //prev = discardPile[-1];
              //List<Card> userPlay = user.Play(prev)
              //effect = Rules(userPlay)
              //discardPile.Add(userPlay)
              //win = user.CheckWinOrLoss()

              //Do effect
              ///prev = discardPile[-1];
              ///List<Card> comp1Play =comp1.Play(prev)
              ///discardPile.Add(comp1Play)
              ///win = comp1.CheckWinOrLoss()

              ///prev = discardPile[-1];
              ///List<Card> comp2Play =comp2.Play(prev)
              ///discardPile.Add(comp2Play)
              ///win = comp2.CheckWinOrLoss()
              
              ///prev = discardPile[-1];
              ///List<Card> comp3Play =comp3.Play(prev)
              ///discardPile.Add(comp3Play)
              ///win = comp3.CheckWinOrLoss()
        }
        public bool IsDone()
        {
            return true;
        }
    }




}
