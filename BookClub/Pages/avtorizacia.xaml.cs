using BookClub.Classes;
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
    /// Логика взаимодействия для avtorizacia.xaml
    /// </summary>
    public partial class avtorizacia : Page
    {
        public avtorizacia()
        {
            InitializeComponent();
            Connect.modeldb = new Models.BookEntities();
        }


        /// <summary>
        /// Метод для авторизации
        /// </summary>
        private void Vxod(object sender, RoutedEventArgs e)
        {
            try
            {
                string login = Login.Text;
                string password = Password.Password;

                if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
                {
                    throw new Exception("Поля логин и пароль не могут быть пустыми.");
                }

                var userObj = Connect.modeldb.users.FirstOrDefault(
                    x => x.login == login && password == x.password);

                if (userObj == null)
                {
                    MessageBox.Show("Пользователя с такими данными не существует!", "Ошибка при авторизации",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    if (userObj.id_type == 1)
                    {
                        Manager.MainFrame.Navigate(new RootMerch());
                    }
                    else if (userObj.id_type == 2)
                    {
                        OrdersWindow ordersWindow = new OrdersWindow();
                        this.Visibility = Visibility.Hidden;
                        ordersWindow.Show();
                    }
                    else if (userObj.id_type == 3)
                    {
                        Manager.MainFrame.Navigate(new merches());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
