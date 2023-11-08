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
    /// Логика взаимодействия для plitka.xaml
    /// </summary>
    public partial class plitka : Page
    {
        public plitka()
        {
            InitializeComponent();
            var merchik = BookEntities.GetContext().point.ToList();
            PointBD.ItemsSource = merchik;
        }
    }
}
