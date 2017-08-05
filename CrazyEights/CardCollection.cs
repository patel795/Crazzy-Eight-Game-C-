using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyEights
{
    public class CardCollection
    {
        private string _label;

        private List<Card> _cardList;

        public CardCollection(string label)
        {
            this._label = label;
            this._cardList = new List<Card>();
        }

        private void AddCard(Card card)
        {
            this._cardList.Add(card);
        }

        private void RemoveCard(Card card)
        {
            this._cardList.Remove(card);
        }

        private int Size()
        {
            return _cardList.Count;
        }

        private bool Empty()
        {
            return _cardList.Count == 0;
        }

        private void Deal()
        {

        }
    }
}
