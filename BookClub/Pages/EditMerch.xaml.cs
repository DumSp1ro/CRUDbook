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
    /// Логика взаимодействия для EditMerch.xaml
    /// </summary>
    public partial class EditMerch : Page
    {
        public EditMerch()
        {
            InitializeComponent();
            EM.ItemsSource = BookEntities.GetContext().merch.ToList();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddMerch());
        }

        private void Delete_Ckick(object sender, RoutedEventArgs e)
        {

        }
    }
}
