﻿using System;
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
        public Card SearchForMatch(Card prev)
        {
            List<Card> potentCards = new List<Card>();
            List<Card> leftOverCards = new List<Card>();
            int numHearts = 0;
            int numSpades = 0;
            int numClubs = 0;
            int numDiamonds = 0;

            //Decides Potential Hands
            foreach(Card card in _hand)
            {
                if(card.Suit == 1)
                {

                }
            }
            //if card.suit == "1"
            //numDiamonds +=1
            //if card.suit == "2"
            //numClubs +=1
            //if card.suit == "3"
            //numHearts += 1
            //if card.suit == "4"
            //numSpades += 1
            //if card.value == prev.value
            //possibleHand = [card]
            //potentCards.append(possibleHand)
            //possibleHand = []
            //elif card.Suit == prev.suit
            //possibleHand = [card]
            //potentCards.append(card)
            //possibleHand = []
            //else
            //leftOverCard.append(card)

            //potentCards = []
            //leftOverCard = []
            //numHearts = 0
            //numSpades = 0
            //numClubs = 0
            //numDiamonds = 0

            //Decides Potential Hands
            //for card in hand
            //if card.suit == "1"
            //numDiamonds +=1
            //if card.suit == "2"
            //numClubs +=1
            //if card.suit == "3"
            //numHearts += 1
            //if card.suit == "4"
            //numSpades += 1
            //if card.value == prev.value
            //possibleHand = [card]
            //potentCards.append(possibleHand)
            //possibleHand = []
            //elif card.Suit == prev.suit
            //possibleHand = [card]
            //potentCards.append(card)
            //possibleHand = []
            //else
            //leftOverCard.append(card)

            //for possHand in potentCards
            //for possCard in possHand
            //for card2 in leftOverCard
            //if possCard.value == card2.value
            //possHand.append(card2)
            //leftOverCard.remove(card2)

            //Chooses hand
            //Random rnd = new Random();
            //int hand = rnd.Next(potentCards.Count);

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
}
