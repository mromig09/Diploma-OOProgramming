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

namespace EDSLprototype
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
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

        void ButtonClick3(object sender, RoutedEventArgs e)
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



        //CreateSeason.Text = String.Empty;
    }
}