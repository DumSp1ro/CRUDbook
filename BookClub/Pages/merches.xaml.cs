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
    /// Логика взаимодействия для merches.xaml
    /// </summary>
    /// 

    public partial class merches : Page
    {
        public merches()
        {
            InitializeComponent();
            var merchik = BookEntities.GetContext().merch.ToList();
            MerchBD.ItemsSource = merchik;
        }

        private void OneOrder(object sender, RoutedEventArgs e)
        {
            OneOrder oneOrder = new OneOrder();
            oneOrder.Show();
        }
    }
}
