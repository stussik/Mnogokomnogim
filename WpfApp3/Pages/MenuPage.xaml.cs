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
using WpfApp3.Models;

namespace WpfApp3.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        Product contextproduct;
        public MenuPage()
        {
            InitializeComponent();
            CBProducts.ItemsSource = App.DB.Product.ToList();
            contextproduct = new Product();
        }

        private void BAddProduct_Click(object sender, RoutedEventArgs e)
        {
            var selectedProduct = CBProducts.SelectedItem as Product;
            var orderProduct = new OrderProduct();
            orderProduct.Product = selectedProduct;
            contextproduct.OrderProduct.Add(orderProduct);
            DGProducts.ItemsSource = contextproduct.OrderProduct.ToList();
        }

        private void BFormOrder_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OformleniePage());

        }
    }
}
