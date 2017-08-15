using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
        private List<Card> _userCards;
        private List<Button> _userButtons;
        private List<Card> playPile;
        private List<Card> userHand;
        private List<Card> comp1Hand;
        private List<Card> comp2Hand;
        private List<Card> comp3Hand;
        private Card _card;
        private Player _player;
        private Deck _gameDeck;
        private bool _win;

        public Play()
        {
            this.InitializeComponent();
            //Creates list for the user cards
            List<Card> userCards = new List<Card>(14);
            _userCards = userCards;
            
            //Creates list if user button cards
            List<Button> userButtons = new List<Button>()
            {
                _userCard1,_userCard2,_userCard3,_userCard4,_userCard5,_userCard6,_userCard7,
                _userCard8,_userCard9,_userCard10,_userCard11,_userCard12,_userCard13,_userCard14
            };
            _userButtons = userButtons;
            



        }

        private void _backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }

        private void _dealButton_Click(object sender, RoutedEventArgs e)
        {
            //Deals the cards out
            _dealButton.IsEnabled = false;
            int handSize = 8;
            Deck deck = new Deck();
            _gameDeck = deck;
            deck.ShuffleCards();

            //Deals to the user
            userHand = deck.Deal(handSize);
            Player player = new Player("jack", userHand);
            _player = player;

            //Deals to the computer
            comp1Hand = deck.Deal(handSize);
            AIComputer comp1 = new AIComputer(comp1Hand);

            //Deals to computer 2
            comp2Hand = deck.Deal(handSize);
            AIComputer comp2 = new AIComputer(comp2Hand);

            //Deals to computer 3
            comp3Hand = deck.Deal(handSize);
            AIComputer comp3 = new AIComputer(comp3Hand);

            //Deals the card in the center
            playPile = deck.Deal(1);
            ShowCardImage(_playPile, playPile[playPile.Count-1]);

            int value = 0;
            List<Button> _userButtons = new List<Button>()
            {
                _userCard1,_userCard2,_userCard3,_userCard4,_userCard5,_userCard6,_userCard7,
                _userCard8,_userCard9,_userCard10,_userCard11,_userCard12,_userCard13,_userCard14
            };
            //Displays the cards in users hand
            foreach (Card card in userHand)
            {
                _userCards.Add(card);
                ShowCardButton(_userButtons[value],card);
                value += 1;
            }
 
            //Makes the cards visible
            for(int x = 0; x < 8;x++)
            {
                _userButtons[x].Visibility = Visibility;
            }
        }
        private void ShowCardImage(Image imageControl, Card card)
        {
            //Displays image for images

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
            //Displays image for buttons

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

        private void _userCard1_Click(object sender, RoutedEventArgs e)
        {
            Player player = new Player("name", _userCards);
            //Checks if card clicked on matches the card in the center
            if(player.CardMatches(_userCards[0],playPile[playPile.Count-1]) == true)
            {
                playPile.Add(_userCards[0]);
                _userCard1.IsEnabled = false;
                ShowCardImage(_playPile, playPile[playPile.Count - 1]);
            }
            //If it doesnt match, then the card becomes disabled
            else
            {
                _userCard1.IsEnabled = false;
            }
                
        }
        private void _userCard2_Click(object sender, RoutedEventArgs e)
        {
            Player player = new Player("name", _userCards);
            if (player.CardMatches(_userCards[1], playPile[playPile.Count - 1]) == true)
            {
                playPile.Add(_userCards[1]);
                _userCard2.IsEnabled = false;
                ShowCardImage(_playPile, playPile[playPile.Count - 1]);
            }
            else
            {
                _userCard2.IsEnabled = false;
            }
        }
        private void _userCard3_Click(object sender, RoutedEventArgs e)
        {
            Player player = new Player("name", _userCards);
            if (player.CardMatches(_userCards[2], playPile[playPile.Count - 1]) == true)
            {
                playPile.Add(_userCards[2]);
                _userCard3.IsEnabled = false;
                ShowCardImage(_playPile, playPile[playPile.Count - 1]);
            }
            else
            {
                _userCard3.IsEnabled = false;
            }
        }
        private void _userCard4_Click(object sender, RoutedEventArgs e)
        {
            Player player = new Player("name", _userCards);
            if (player.CardMatches(_userCards[3], playPile[playPile.Count - 1]) == true)
            {
                playPile.Add(_userCards[0]);
                _userCard4.IsEnabled = false;
                ShowCardImage(_playPile, playPile[playPile.Count - 1]);
            }
            else
            {
                _userCard4.IsEnabled = false;
            }
        }
        private void _userCard5_Click(object sender, RoutedEventArgs e)
        {
            Player player = new Player("name", _userCards);
            if (player.CardMatches(_userCards[4], playPile[playPile.Count - 1]) == true)
            {
                playPile.Add(_userCards[4]);
                _userCard5.IsEnabled = false;
                ShowCardImage(_playPile, playPile[playPile.Count - 1]);
            }
            else
            {
                _userCard5.IsEnabled = false;
            }
        }
        private void _userCard6_Click(object sender, RoutedEventArgs e)
        {
            Player player = new Player("name", _userCards);
            if (player.CardMatches(_userCards[5], playPile[playPile.Count - 1]) == true)
            {
                playPile.Add(_userCards[5]);
                _userCard6.IsEnabled = false;
                ShowCardImage(_playPile, playPile[playPile.Count - 1]);
            }
            else
            {
                _userCard6.IsEnabled = false;
            }
        }
        private void _userCard7_Click(object sender, RoutedEventArgs e)
        {
            Player player = new Player("name", _userCards);
            if (player.CardMatches(_userCards[6], playPile[playPile.Count - 1]) == true)
            {
                playPile.Add(_userCards[6]);
                _userCard7.IsEnabled = false;
                ShowCardImage(_playPile, playPile[playPile.Count - 1]);
            }
            else
            {
                _userCard7.IsEnabled = false;
            }
        }
        private void _userCard8_Click(object sender, RoutedEventArgs e)
        {
            Player player = new Player("name", _userCards);
            if (player.CardMatches(_userCards[7], playPile[playPile.Count - 1]) == true)
            {
                playPile.Add(_userCards[7]);
                _userCard8.IsEnabled = false;
                ShowCardImage(_playPile, playPile[playPile.Count - 1]);
            }
            else
            {
                _userCard8.IsEnabled = false;
            }
        }
        private void _userCard9_Click(object sender, RoutedEventArgs e)
        {
            Player player = new Player("name", _userCards);
            if (player.CardMatches(_userCards[8], playPile[playPile.Count - 1]) == true)
            {
                playPile.Add(_userCards[8]);
                _userCard9.IsEnabled = false;
                ShowCardImage(_playPile, playPile[playPile.Count - 1]);
            }
            else
            {
                _userCard9.IsEnabled = false;
            }
        }
        private void _userCard10_Click(object sender, RoutedEventArgs e)
        {
            Player player = new Player("name", _userCards);
            if (player.CardMatches(_userCards[9], playPile[playPile.Count - 1]) == true)
            {
                playPile.Add(_userCards[9]);
                _userCard10.IsEnabled = false;
                ShowCardImage(_playPile, playPile[playPile.Count - 1]);
            }
            else
            {
                _userCard10.IsEnabled = false;
            }
        }
        private void _userCard11_Click(object sender, RoutedEventArgs e)
        {
            Player player = new Player("name", _userCards);
            if (player.CardMatches(_userCards[10], playPile[playPile.Count - 1]) == true)
            {
                playPile.Add(_userCards[10]);
                _userCard11.IsEnabled = false;
                ShowCardImage(_playPile, playPile[playPile.Count - 1]);
            }
            else
            {
                _userCard11.IsEnabled = false;
            }
        }
        private void _userCard12_Click(object sender, RoutedEventArgs e)
        {
            Player player = new Player("name", _userCards);
            if (player.CardMatches(_userCards[11], playPile[playPile.Count - 1]) == true)
            {
                playPile.Add(_userCards[11]);
                _userCard12.IsEnabled = false;
                ShowCardImage(_playPile, playPile[playPile.Count - 1]);
            }
            else
            {
                _userCard12.IsEnabled = false;
            }
        }
        private void _userCard13_Click(object sender, RoutedEventArgs e)
        {
            Player player = new Player("name", _userCards);
            if (player.CardMatches(_userCards[12], playPile[playPile.Count - 1]) == true)
            {
                playPile.Add(_userCards[12]);
                _userCard13.IsEnabled = false;
                ShowCardImage(_playPile, playPile[playPile.Count - 1]);
            }
            else
            {
                _userCard13.IsEnabled = false;
            }
        }
        private void _userCard14_Click(object sender, RoutedEventArgs e)
        {
            Player player = new Player("name", _userCards);
            if (player.CardMatches(_userCards[13], playPile[playPile.Count - 1]) == true)
            {
                playPile.Add(_userCards[13]);
                _userCard14.IsEnabled = false;
                ShowCardImage(_playPile, playPile[playPile.Count - 1]);
            }
            else
            {
                _userCard14.IsEnabled = false;
            }
        }

        private void _cantGoButton_Click(object sender, RoutedEventArgs e)
        {
            _cantGoButton.IsEnabled = false;
            Player player = new Player("name", _userCards);
            List<Card> cardsDrawn = _gameDeck.Deal(1);
            //Checks if card draw is equal to the card in the pile
            if(player.CardMatches(cardsDrawn[cardsDrawn.Count-1],playPile[playPile.Count -1]) == true)
            {
                playPile.Add(cardsDrawn[cardsDrawn.Count-1]);
                ShowCardImage(_playPile, playPile[playPile.Count - 1]);
            }
            foreach (Button button in _userButtons)
            {
                button.IsEnabled = false;
            }
            //AI Computers turns
            AIComputer comp1 = new AIComputer(comp1Hand);
            //Adds the AI computers cards into the pile
            playPile.AddRange(comp1.Play(playPile[playPile.Count - 1]));
            //Checks if the computer wins
            _win = comp1.CheckWinOrLoss();
            //Shows the card in the center pile
            ShowCardImage(_playPile, playPile[playPile.Count - 1]);
            AIComputer comp2 = new AIComputer(comp2Hand);
            playPile.AddRange(comp2.Play(playPile[playPile.Count - 1]));
            _win = comp2.CheckWinOrLoss();
            ShowCardImage(_playPile, playPile[playPile.Count - 1]);
            AIComputer comp3 = new AIComputer(comp3Hand);
            playPile.AddRange(comp3.Play(playPile[playPile.Count - 1]));
            _win = comp3.CheckWinOrLoss();
            ShowCardImage(_playPile, playPile[playPile.Count - 1]);
       
            _cantGoButton.IsEnabled = true;

            //Enables all the user card buttons after the AI's have gone
            foreach (Button button in _userButtons)
            {
                button.IsEnabled = true;
            }
        }
    }
}
