using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyEights
{
    /// <summary>
    /// Represents a deck of cards
    /// </summary>
    class Deck
    {
        //HAS-A relationship
        private List<Card> _cardList;

        public Deck()
        {
            _cardList = new List<Card>();  //HAS-A composition

            CreateCards();

            PrintCards();
        }

        //Implement a read-only property to return the
        //number of cards in the deck called CardCount
        public int CardCount
        {
            get { return _cardList.Count; }
        }


        private void CreateCards()
        {
            //repeat going through every suit to create the cards in each suit
            for (byte iSuit = 1; iSuit <= 4; iSuit++)
            {
                //obtain the suit from the suit index through typecasting
                CardSuit suit = (CardSuit)iSuit;

                //repeat going through every card value in the current suit
                for (byte value = 1; value <= 13; value++)
                {
                    //create the card with the value and the suit
                    Card card = new Card(value, suit);

                    //add the card to the 
                    _cardList.Add(card);
                }
            }
        }

        public void PrintCards()
        {
            //iterate through all the cards in the list
            //equivalent to the for loop below
            foreach (Card card in _cardList)
            {
                Debug.WriteLine(card);
            }

            //TODO: use a for loop go through all the cards in _cardList
            //and print the content
            //Use Debug.WriteLine() instead of Console.WriteLine()
            //for (byte iCard = 0; iCard < _cardList.Count; iCard++)
            //{
            //    //extract the current card object from the list
            //    Card card = _cardList[iCard];

            //    //print the card content
            //    Debug.WriteLine(card);
            //}
        }

        internal void ShuffleCards()
        {
            //TODO: implement this using a Fisher-Yates shuffle algorithm
            throw new NotImplementedException();
        }

        internal bool GetPairOfCards(out Card playerCard, out Card houseCard)
        {
            //generate a random number
            Random randomizer = new Random();
            int playerRandNo = randomizer.Next(_cardList.Count);
            playerCard = _cardList[playerRandNo];
            _cardList.RemoveAt(playerRandNo);

            //extract and return the card
            int houseRandNo = randomizer.Next(_cardList.Count);
            houseCard = _cardList[houseRandNo];
            _cardList.RemoveAt(houseRandNo);

            return true;
        }
    }
}
