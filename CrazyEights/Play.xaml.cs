﻿using System;
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
        private Deck _game;
        public Play()
        {
            this.InitializeComponent();
            _game = new Deck();
        }

        private void _backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }

        private void _btnDeal_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage cardBack = new BitmapImage(new Uri("ms-appx:///Assets/CardAssets/playing-card-back.jpg"));
            _imgDeal.Source = cardBack;
            _game.Deal();
        }
    }
}
