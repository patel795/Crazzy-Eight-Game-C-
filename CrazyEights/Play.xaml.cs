using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace CrazyEights
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Play : Page
    {
        private List<Button> _userCards;
        public Play()
        {
            this.InitializeComponent();
            _userCards = new List<Button>() {
                _userCard1, _userCard2 , _userCard3 , _userCard4,_userCard5,_userCard6,_userCard7,
                _userCard8, _userCard9, _userCard10, _userCard11,_userCard12,_userCard13};
        }

        private void _backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }

        private void _dealButton_Click(object sender, RoutedEventArgs e)
        {
            int handSize = 8;
            Deck deck = new Deck();
            deck.ShuffleCards();

            List<Card> userHand = deck.Deal(handSize);
            Player user = new Player("jack", userHand);

            List<Card> comp1Hand = deck.Deal(handSize);
            AIComputer comp1 = new AIComputer();

            List<Card> comp2Hand = deck.Deal(handSize);
            AIComputer comp2 = new AIComputer();

            List<Card> comp3Hand = deck.Deal(handSize);
            AIComputer comp3 = new AIComputer();

            List<Card> playPile = deck.Deal(1);
            ShowCardImage(_playPile, playPile[playPile.Count-1]);

            int value = 0;
            foreach(Card card in userHand)
            {
                ShowCardButton(_userCards[value], card);
                value += 1;
            }
        }
        private void ShowCardImage(Image imageControl, Card card)
        {
            //determine the name of the image file to be used
            //based on card value and suit
            char suitId = card.Suit.ToString()[0];
            string fileName = $"{suitId}{card.Value.ToString("00")}.png";

            //display the image asset in the given image control
            string imgAssetPath = $"ms-appx:///Assets/CardImages/{fileName}";
            imageControl.Source = new BitmapImage(new Uri(imgAssetPath));
        }
        private void ShowCardButton(Button imageControl, Card card)
        {
            //determine the name of the image file to be used
            //based on card value and suit
            char suitId = card.Suit.ToString()[0];
            string fileName = $"{suitId}{card.Value.ToString("00")}.png";

            //display the image asset in the given image control
            string imgAssetPath = $"ms-appx:///Assets/CardImages/{fileName}";
            BitmapImage img = new BitmapImage(new Uri(imgAssetPath));
            var brush = new ImageBrush();
            brush.ImageSource = img;
            imageControl.Background = brush;
        }
    }
}
