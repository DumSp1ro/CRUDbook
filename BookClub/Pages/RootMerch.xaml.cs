using BookClub.Classes;
using BookClub.Models;
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

namespace BookClub.Pages
{
    /// <summary>
    /// Логика взаимодействия для RootMerch.xaml
    /// </summary>
    public partial class RootMerch : Page
    {
        public RootMerch()
        {
            
            InitializeComponent();
            var merchik = BookEntities.GetContext().merch.ToList();
            MerchBD.ItemsSource = merchik;
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddMerch());

        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new EditMerch());
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new EditMerch());
        }

        private void Orders(object sender, RoutedEventArgs e)
        {
            OrdersWindow ordersWindow = new OrdersWindow();
            this.Visibility = Visibility.Hidden;
            ordersWindow.Show();
        }
    }
}
