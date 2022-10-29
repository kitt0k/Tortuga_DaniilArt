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
using Tortuga_DaniilArtyukhov.DB;

namespace Tortuga_DaniilArtyukhov.Windows
{
    /// <summary>
    /// Логика взаимодействия для FoodInfoWindow.xaml
    /// </summary>
    public partial class FoodInfoWindow : Window
    {
        DB.Food Food = new DB.Food();
        public FoodInfoWindow(DB.Food editFood)
        {
            InitializeComponent();
            Food = editFood;


            NameProduct.Text = editFood.FoodName;
            CostProduct.Text = Convert.ToString(editFood.Cost);
            DescriptionProduct.Text = editFood.Description;

            Image myImage = new Image();
            BitmapImage bit = new BitmapImage();
            bit.BeginInit();
            bit.UriSource = new Uri(editFood.Photo, UriKind.Relative);
            bit.EndInit();
            myImage.Stretch = Stretch.Fill;
            myImage.Source = bit;
            Photo.Source = bit;


        }
    }
}
