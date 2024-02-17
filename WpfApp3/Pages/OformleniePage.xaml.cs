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

namespace WpfApp3.Pages
{
    /// <summary>
    /// Логика взаимодействия для OformleniePage.xaml
    /// </summary>
    public partial class OformleniePage : Page
    {
        public OformleniePage()
        {
            InitializeComponent();
            CBTypeofDelivery.ItemsSource = App.DB.TypeofDelivery.ToList();
            CBTypeofPayment.ItemsSource = App.DB.TypeofPayment.ToList();
        }

        private void BExit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BFormOrder_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
