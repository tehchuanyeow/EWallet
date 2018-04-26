using System;
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
    /// Interaction logic for EWalletHome.xaml
    /// </summary>
    public partial class EWalletHome : Page
    {
        public EWalletHome()
        {
            InitializeComponent();
            string userType = "Adrian!";
            Welcome(userType);
        }


        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            EWalletLogin ewalletLogin = new EWalletLogin();
            NavigationService.Navigate(ewalletLogin);
            //Uri uri = new Uri("EWalletManageAcc.xaml", UriKind.Relative);
            //this.NavigationService.Navigate(uri);

        }

        private void manageAccount_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("EWalletManageAcc.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }

      
        private void manageWalletButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void manageInvoiceButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Welcome(string userType)
        {
            welcome.Inlines.Add(", " + userType);
        }

    }
}
