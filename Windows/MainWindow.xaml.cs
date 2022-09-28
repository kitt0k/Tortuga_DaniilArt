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
using System.Windows.Shapes;
using Tortuga_DaniilArtyukhov.Windows;


namespace Tortuga_DaniilArtyukhov.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Table1_Click(object sender, RoutedEventArgs e)
        {
            
            var resultClick = MessageBox.Show("Вы уверены что хотите выбрать 1 стол?", "Выбор стола", MessageBoxButton.YesNo);
            if (resultClick == MessageBoxResult.Yes)
            {
                MainMenuWindow mainWindow = new MainMenuWindow();
               // MainMenuWindow.Num.Text = n1.Text;
                mainWindow.Show();
                this.Close();
                              
            }

        }

        private void Table2_Click(object sender, RoutedEventArgs e)
        {
            var resultClick = MessageBox.Show("Вы уверены что хотите выбрать 2 стол?", "Выбор стола", MessageBoxButton.YesNo);
            if (resultClick == MessageBoxResult.Yes)
            {
                MainMenuWindow mainWindow = new MainMenuWindow();
                mainWindow.Show();
                this.Close();
            }
        }

        private void Table3_Click(object sender, RoutedEventArgs e)
        {
            var resultClick = MessageBox.Show("Вы уверены что хотите выбрать 3 стол?", "Выбор стола", MessageBoxButton.YesNo);
            if (resultClick == MessageBoxResult.Yes)
            {
                MainMenuWindow mainWindow = new MainMenuWindow();
                mainWindow.Show();
                this.Close();
            }
        }

        private void Table4_Click(object sender, RoutedEventArgs e)
        {
            var resultClick = MessageBox.Show("Вы уверены что хотите выбрать 4 стол?", "Выбор стола", MessageBoxButton.YesNo);
            if (resultClick == MessageBoxResult.Yes)
            {
                MainMenuWindow mainWindow = new MainMenuWindow();
                mainWindow.Show();
                this.Close();
            }
        }

        private void Table5_Click(object sender, RoutedEventArgs e)
        {
            var resultClick = MessageBox.Show("Вы уверены что хотите выбрать 5 стол?", "Выбор стола", MessageBoxButton.YesNo);
            if (resultClick == MessageBoxResult.Yes)
            {
                MainMenuWindow mainWindow = new MainMenuWindow();
                mainWindow.Show();
                this.Close();
            }
        }

        private void Table6_Click(object sender, RoutedEventArgs e)
        {
            var resultClick = MessageBox.Show("Вы уверены что хотите выбрать 6 стол?", "Выбор стола", MessageBoxButton.YesNo);
            if (resultClick == MessageBoxResult.Yes)
            {
                MainMenuWindow mainWindow = new MainMenuWindow();
                mainWindow.Show();
                this.Close();
            }
        }

        private void Table7_Click(object sender, RoutedEventArgs e)
        {
            var resultClick = MessageBox.Show("Вы уверены что хотите выбрать 7 стол?", "Выбор стола", MessageBoxButton.YesNo);
            if (resultClick == MessageBoxResult.Yes)
            {
                MainMenuWindow mainWindow = new MainMenuWindow();
                mainWindow.Show();
                this.Close();
            }

        }

        private void Table8_Click(object sender, RoutedEventArgs e)
        {
            var resultClick = MessageBox.Show("Вы уверены что хотите выбрать 8 стол?", "Выбор стола", MessageBoxButton.YesNo);
            if (resultClick == MessageBoxResult.Yes)
            {
                MainMenuWindow mainWindow = new MainMenuWindow();
                mainWindow.Show();
                this.Close();
            }

        }
    }
}
