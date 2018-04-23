﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EWallet_ClassLibrary;

namespace EWallet
{
    /// <summary>
    /// Interaction logic for EWalletHomePage.xaml
    /// </summary>
    public partial class EWalletHome : Page
    {
        public EWalletHome()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            

            Uri uri = new Uri("EWalletLogin.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }
    }
}












