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

namespace EWallet
{
    /// <summary>
    /// Interaction logic for EWalletSelectAccount.xaml
    /// </summary>
    public partial class EWalletSelectAccount : Page
    {
        public EWalletSelectAccount()
        {
            InitializeComponent();
            
        }

        private void adminButton_Checked(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("EWalletCreateAdmin.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);


        }

        private void clientButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void projectButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void resourceButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}