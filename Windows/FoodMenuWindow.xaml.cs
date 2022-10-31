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

        int count = 0;

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

        private void listProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }



        private void listProduct_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var editFood = new DB.Food();
            if (listProduct.SelectedItem is DB.Food)
            {
                editFood = listProduct.SelectedItem as DB.Food;
            }

            FoodInfoWindow addReaderWindow = new FoodInfoWindow(editFood);
            this.Opacity = 0.2;
            addReaderWindow.ShowDialog();
            listProduct.ItemsSource = AppData.Context.Food.ToList();
            this.Opacity = 1;
        }

        public void plus_Click(object sender, RoutedEventArgs e)
        {
            if (count == 0)
            {
                TBCount.Text = null;
                count = 1;
            }
            else
            {
                TBCount.Text++;

                count = Convert.ToDouble(TBCount.Text);
            }
        }
    }
}
