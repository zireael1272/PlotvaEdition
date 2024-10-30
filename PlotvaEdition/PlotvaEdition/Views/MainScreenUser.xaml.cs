using PlotvaEdition.DB;
using PlotvaEdition.Models;
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

namespace PlotvaEdition.Views
{
    /// <summary>
    /// Логика взаимодействия для MainScreenUser.xaml
    /// </summary>
    public partial class MainScreenUser : Window
    {
        private readonly DBOperation dbOperation;
        private Users user;
        public MainScreenUser(Users user)
        {
            InitializeComponent();
            this.Width = 800;
            this.Height = 480;
            dbOperation = new DBOperation(new DeliveryDbContext());
            this.user = user;
        }

        private void Account_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Account(user, this));
        }

        private void HistoryParcel_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new HistoryPackage());
        }

        private void AddParcel_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AddParcel());
        }
    }
}
