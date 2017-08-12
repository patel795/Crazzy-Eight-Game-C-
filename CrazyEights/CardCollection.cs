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
            BitmapImage cardBack = new BitmapImage(new Uri("ms-appx:///Assets/CardAssets/playing-card-back.jpg"));
        }

        
           

    }
}
