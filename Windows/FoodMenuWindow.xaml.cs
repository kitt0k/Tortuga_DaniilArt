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
    /// Логика взаимодействия для FoodMenuWindow.xaml
    /// </summary>
    public partial class FoodMenuWindow : Window
    {
        public FoodMenuWindow()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainMenuWindow mainWindow = new MainMenuWindow();
            mainWindow.Show();
            this.Close();
        }

        private void ToCart_Click(object sender, RoutedEventArgs e)
        {
            Cart mainWindow = new Cart();
            mainWindow.Show();
            this.Close();
        }
    }
}
