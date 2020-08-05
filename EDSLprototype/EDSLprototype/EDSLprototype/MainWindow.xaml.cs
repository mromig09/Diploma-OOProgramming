using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
     
        private void ButtonClick1(object sender, RoutedEventArgs e)
        {
            Main.Content = new SeasonPage();
        }

        private void ButtonClick2(object sender, RoutedEventArgs e)
        {
            Main.Content = new ResultsPage();
        }

        private void ButtonClick3(object sender, RoutedEventArgs e)
        {
            Main.Content = new ReportsPage();
        }

        private void ButtonClick4(object sender, RoutedEventArgs e)
        {
            Main.Content = new ClubsPage();
        }

        private void ButtonClick5(object sender, RoutedEventArgs e)
        {
            Main.Content = new TeamsPage();
        }

        private void ButtonClick6(object sender, RoutedEventArgs e)
        {
            Main.Content = new PlayersPage();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Main_Navigated(object sender, NavigationEventArgs e)
        {

        }
        
        private void EmptyText(object sender, RoutedEventArgs e)
        {
            CreateSeason.Text = String.Empty;
        }
        
        private void btnClickOk1(object sender, RoutedEventArgs e)
        {
            divSelect.Visibility = Visibility.Visible;
            roundSelect.Visibility = Visibility.Visible;
            startDate.Visibility = Visibility.Visible;
            selectDate.Visibility = Visibility.Visible;
            createOk.Visibility = Visibility.Visible;
        }

        private void btnClickOk2(object sender, RoutedEventArgs e)
        {
            //existingEdit.Visibility = Visibility.Visible;
            save.Visibility = Visibility.Visible;
            viewDraw.Visibility = Visibility.Visible;

        }

        private void btnClickOk3(object sender, RoutedEventArgs e)
        {
            createEdit.Visibility = Visibility.Visible;
            createDraw.Visibility = Visibility.Visible;
            save.Visibility = Visibility.Visible;
            viewDraw.Visibility = Visibility.Visible;
            listOfDates.Visibility = Visibility.Visible;        
        }

        private void EditDate(object sender, RoutedEventArgs e)
        {
            deleteListOfDates.Visibility = Visibility.Visible;
            remove.Visibility = Visibility.Visible;
        }

        private void removeData(object sender, RoutedEventArgs e)
        {
            deleteListOfDates.Items.Remove(deleteListOfDates.SelectedItem);
        }
    }
}
