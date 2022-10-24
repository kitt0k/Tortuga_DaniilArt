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
using Tortuga_DaniilArtyukhov.Classes;
using Tortuga_DaniilArtyukhov.DB;

namespace Tortuga_DaniilArtyukhov.Windows
{
    /// <summary>
    /// Логика взаимодействия для FoodMenuWindow.xaml
    /// </summary>
    public partial class FoodMenuWindow : Window
    {

        List<Food> productList = new List<Food>();


        public FoodMenuWindow()
        {
            InitializeComponent();
            listProduct.ItemsSource = AppData.Context.Food.ToList();
        }

       
        private void BtnBack_Click(object sender, RoutedEventArgs e)
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

        private void Cart2_Click(object sender, RoutedEventArgs e)
        {

            Cart mainWindow = new Cart();
            mainWindow.Show();
            this.Close();
        }

    }
}
