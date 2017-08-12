﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyEights
{
    public class AIComputer
    {
        private string _name;
        private List<Card> _hand;
       
        public AIComputer()
        {

        }
        public List<Card> Play(CardGame cardGame, Card prev)
        {
            List<List<Card>> potentHands = FindsPotentialHands(prev);
            List<Card> handToPlay = DecideHandToPlay(potentHands);
            List<Card> playHand = OrderOfPlay(prev,handToPlay);
            return playHand;
            //playHand.add(cards in center)
             
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
                else if (card.SuitName == "Hearts")
                {
                    numHearts += 1;
                }
                else if (card.SuitName == "Clubs")
                {
                    numClubs += 1;
                }
                else if (card.SuitName == "Spades")
                {
                    numSpades += 1;
                }
                if (card.Value == prev.Value)
                {
                    bool leave = true;
                    foreach (List<Card> hand in potentHands)
                    {
                        if (hand[0].Value == card.Value)
                        {
                            hand.Add(card);
                            leave = false;
                            break;
                        }
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
        public List<Card> DecideHandToPlay(List<List<Card>> potentHands)
        {
            Random random = new Random();
            int hand = random.Next(potentHands.Count);
            return potentHands[hand];
        }
        public List<Card> OrderOfPlay(Card prev, List<Card> hand)
        {
            if (hand[0].Value == prev.Value)
            {
                Random rand = new Random();
                List<Card> playHand = hand.OrderBy(c => rand.Next()).Select(c => c).ToList();
                return playHand;
            }

            else
            {
                List<Card> handOrder = new List<Card>(hand.Count);
                int spot = 0;
                foreach (Card card in hand)
                {
                    if(card.Suit == prev.Suit)
                    {
                        handOrder[0] = card;
                    }
                    else
                    {
                        handOrder[spot + 1] = card;
                    }
                
                }
                return handOrder;
            }
        }
        public bool CheckWinOrLoss()
        {
            if (_hand.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
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
