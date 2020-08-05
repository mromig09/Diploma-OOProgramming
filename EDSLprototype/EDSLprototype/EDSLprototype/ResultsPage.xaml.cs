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

namespace EDSLprototype
{
    /// <summary>
    /// Interaction logic for ResultsPage.xaml
    /// </summary>
    public partial class ResultsPage : Page
    {
        public ResultsPage()
        {
            InitializeComponent();
        }

        private void btnClickOk(object sender, RoutedEventArgs e)
        {
            games.Visibility = Visibility.Visible;
            viewresults.Visibility = Visibility.Visible;
        }

        private void resultsView(object sender, RoutedEventArgs e)
        {
            scores.Visibility = Visibility.Visible;
            saveResults.Visibility = Visibility.Visible;
        }

        private void save(object sender, RoutedEventArgs e)
        {
            updateLadder.Visibility = Visibility.Visible;
           
        }
    }
}
