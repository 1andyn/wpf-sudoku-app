using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_sudoku_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int int_GameDifficulty;

        enum Difficulty
        {
            Easy = 0,
            Medium = 1,
            Hard = 2,
        }

        public MainWindow()
        {
            InitializeComponent();
            int_GameDifficulty = (int) Difficulty.Easy; //initialized to easy
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            hideMainMenu();
            showGameScreen();
            Trace.WriteLine("Play clicked!");
        }

        private void btnSolve_Click(object sender, RoutedEventArgs e)
        {
            Trace.WriteLine("Solve clicked!");
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnDiff_Click(object sender, RoutedEventArgs e)
        {
            Button btn_sourceClick = e.Source as Button;
            switch(btn_sourceClick.Name) {
                case "Easy":
                    int_GameDifficulty = (int)Difficulty.Easy;
                    break;
                case "Medium":
                    int_GameDifficulty = (int)Difficulty.Medium;
                    break;
                case "Hard":
                    int_GameDifficulty = (int)Difficulty.Hard;
                    break;
            }

            gridGameDiff.Visibility = Visibility.Hidden; //Hide Diff buttons, show Game Control
            gridGameControl.Visibility = Visibility.Visible;

        }



        private void hideMainMenu()
        {
            gridMainMenu.Visibility = Visibility.Hidden;
        }

        private void showGameScreen()
        {
            gridGameScreen.Visibility = Visibility.Visible;
            gridGameDiff.Visibility = Visibility.Visible; //Show difficulty buttons before showing control buttons
            gridGameControl.Visibility = Visibility.Hidden;
        }

    }
}
