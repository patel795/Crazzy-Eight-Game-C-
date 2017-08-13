using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyEights
{
    /// <summary>
    /// Suit of the cards that are being used in the game
    /// Enums are user-defined integral types
    /// </summary>
    public enum CardSuit
    {
        Diamonds = 1,
        Clubs,
        Hearts,
        Spades
    }

    public enum CardValue
    {
        Ace = 0,
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
    }

    /// <summary>
    /// Represents a playing card with a value and a suit
    /// </summary>
    public class Card
    {
        /// <summary>
        /// The numeric value of the playing card
        /// </summary>
        private byte _value;

        /// <summary>
        /// The suit of the playing card
        /// </summary>
        private CardSuit _suit;

        private bool _playable;

        public Card(byte value, CardSuit suit)
        {
            //"this" is equivalent to "self" in Python
            this._value = value;
            
            //this. is added by the compiler, it is not necessary to add it explicitly
            _suit = suit; //HAS-A composition relationship, suit value is NOT shared and is exclusively owned
        }

        public byte Value
        {
            get { return _value; }
            set { _value = value; }
        }
        public bool Playable
        {
            get { return _playable; }
            set { _playable = value; }
        }
        public CardSuit Suit
        {
            get { return _suit; }
            set { _suit = value; }
        }

        public string CardName
        {
            get
            {
                switch (_value)
                {
                    case 1:
                        return "Ace";

                    case 11:
                        return "Jack";

                    case 12:
                        return "Queen";

                    case 13:
                        return "King";

                    default:
                        //for every other value, use the value itself as the name
                        return _value.ToString();
                }
            }
        }

        public string SuitName
        {
            get
            {
                switch (_suit)
                {
                    case CardSuit.Diamonds:
                    case CardSuit.Clubs:
                    case CardSuit.Hearts:
                    case CardSuit.Spades:
                        return _suit.ToString();

                    default:
                        //Defensive programming: programming your assumptions
                        Debug.Assert(false, "Unknown suit value");
                        return "N/A";
                }
            }
        }
        public bool IsPlayable(bool play)
        {
            _playable = play;
            return play;
        }

        public override string ToString()
        {
            return $"{this.CardName} of {this.SuitName}";
        }
    }
}
