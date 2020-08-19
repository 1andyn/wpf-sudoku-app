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

namespace wpf_sudoku_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Button btnPlay = new Button();
            Button btnSolve = new Button();
            btnPlay.Name = "btnPlay";
            btnSolve.Name = "btnSolve";

            btnPlay.Click += btnPlay_Click;
            btnSolve.Click += btnSolve_Click;

            InitializeComponent();
        }



        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            // do something
        }

        private void btnSolve_Click(object sender, RoutedEventArgs e)
        {
            // do something
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
