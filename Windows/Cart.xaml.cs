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

namespace Tortuga_DaniilArtyukhov.Windows
{
    /// <summary>
    /// Логика взаимодействия для Cart.xaml
    /// </summary>
    public partial class Cart : Window
    {
        public Cart()
        {
            InitializeComponent();           
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            FoodMenuWindow mainWindow = new FoodMenuWindow();
            mainWindow.Show();
            this.Close();
        }

        private void ToCart_Click(object sender, RoutedEventArgs e)
        {
            OrderDoneWindow mainWindow = new OrderDoneWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
