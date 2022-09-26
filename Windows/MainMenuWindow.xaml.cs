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

namespace Tortuga_DaniilArtyukhov.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainMenuWindow.xaml
    /// </summary>
    public partial class MainMenuWindow : Window
    {
        public MainMenuWindow()
        {
            InitializeComponent();
        }

        private void BackToMainW_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void FoodMenu_Click(object sender, RoutedEventArgs e)
        {
            FoodMenuWindow mainWindow = new FoodMenuWindow();
            mainWindow.Show();
            this.Close();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            AboutUsWindow mainWindow = new AboutUsWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
