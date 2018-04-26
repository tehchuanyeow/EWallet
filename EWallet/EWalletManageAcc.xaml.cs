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
    /// Interaction logic for EWalletManageAcc.xaml
    /// </summary>
    public partial class EWalletManageAcc : Page
    {
        public EWalletManageAcc()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, RoutedEventArgs e)
        {
            frame1.Content = new EWalletSelectAccount();
            //Uri uri = new Uri("EWalletCreateAccount.xaml", UriKind.Relative);
            //this.NavigationService.Navigate(uri);

        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
