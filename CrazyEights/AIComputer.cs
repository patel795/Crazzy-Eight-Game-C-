using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyEights
{
    class AIComputer
    {
        private string _name;
        private List<Card> _hand;

        public AIComputer()
        {

        }
        public Card Play(CardGame cardGame)
        {
            return 
        }
        public List<List<Card>> FindsPotentialHands(Card prev)
        {
            List<List<Card>> potentHands = new List<List<Card>>();
            List<Card> leftOverCards = new List<Card>();
            int numHearts = 0;
            int numSpades = 0;
            int numClubs = 0;
            int numDiamonds = 0;

            //Decides Potential Hands
            foreach (Card card in _hand)
            {
                if (card.SuitName == "Diamonds")
                {
                    numDiamonds += 1;
                }
                if (card.SuitName == "Hearts")
                {
                    numHearts += 1;
                }
                if (card.SuitName == "Clubs")
                {
                    numClubs += 1;
                }
                if (card.SuitName == "Spades")
                {
                    numSpades += 1;
                }
                else if (card.Value == prev.Value)
                {
                    bool leave = true;
                    foreach (List<Card> hand in potentHands)
                    {
                        if (hand[0].Value == card.Value)
                            hand.Add(card);
                            leave = false;
                            break;
                    }
                    if (leave == true)
                    {
                        List<Card> possibleHand = new List<Card>();
                        possibleHand.Add(card);
                        potentHands.Add(possibleHand);
                        possibleHand.Remove(card);
                    }
                }
                else if (card.Suit == prev.Suit)
                {
                    List<Card> possibleHand = new List<Card>();
                    possibleHand.Add(card);
                    potentHands.Add(possibleHand);
                    possibleHand.Remove(card);
                }
                else
                {
                    leftOverCards.Add(card);
                }
            }
            foreach (List<Card> possHand in potentHands)
            {
                foreach (Card possCard in possHand)
                {
                    foreach (Card card in leftOverCards)
                    {
                        if(possCard.Value == card.Value)
                        {
                            possHand.Add(card);
                            leftOverCards.Remove(card);
                        }
                    }
                }
            }
            return potentHands;
        }
        public List<Card> DecideHandToPlay(Card prev, List<List<Card>> potentHands)
        {
            Random random = new Random();
            int hand = random.Next(potentHands.Count);
            return potentHands[hand];
        }
        public List<Card> OrderOfPlay(List<Card> hand)
        {

        }

            

            //Picks what card to go on top of chosen hand
            //suitRank = {}
            //suitRank["Diamonds"] = numDiamonds
            //suitRank["Clubs"] = numClubs
            //suitRank["Hearts"] = numHearts
            //suitRank["Spades"] = numSpades
            //suitRank.Sort()
            //suitNum = 0

            //for suit in suitRank:
            //suitNum += 1
            //suit = suitNum

            //orderHand = []
            //for card in playHand
            //if prev.value() == card.value()
            //if card
            //else:
            //if card.suit() == prev.suit()
            //orderHand.append(card)
            //prev = card
            //playHand.remove(card)
    }
}
