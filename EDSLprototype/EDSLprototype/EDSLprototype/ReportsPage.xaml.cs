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
    /// Interaction logic for ReportsPage.xaml
    /// </summary>
    public partial class ReportsPage : Page
    {
        public ReportsPage()
        {
            InitializeComponent();
        }

       
        private void viewDraw(object sender, RoutedEventArgs e)
        {
            Main.Content = new ReportsPage();
        }

        private void buttonclickDraw(object sender, RoutedEventArgs e)
        {
            Draw.Visibility = Visibility.Visible;
            DrawHeader.Visibility = Visibility.Visible;
            
        }


        private void buttonClickLadder(object sender, RoutedEventArgs e)
        {
            Ladder.Visibility = Visibility.Visible;
            LadderHeader.Visibility = Visibility.Visible;
            Cover.Visibility = Visibility.Visible;
            Cover2.Visibility = Visibility.Visible;
        }

        private void ComboBox_SelectionChanged1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged2(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
