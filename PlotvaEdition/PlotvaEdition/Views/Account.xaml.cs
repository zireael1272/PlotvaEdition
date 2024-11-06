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
    /// Логика взаимодействия для Account.xaml
    /// </summary>
    public partial class Account : Page
    {
        private readonly DBOperationUser dbOperation;
        private Users user;
        private MainScreenUser parent;
        public Account(Users user, MainScreenUser parent)
        {
            InitializeComponent();
            dbOperation = new DBOperationUser(new DeliveryDbContext());
            this.user = user;
            this.parent = parent;
        }

        private void Account_Loaded(object sender, RoutedEventArgs e)
        {
            FullName.Content = $"{user.Name} {user.Surname} {user.Patronymic}";
        }


        private void DeleteAccount_Click(object sender, RoutedEventArgs e)
        {
            if(dbOperation.DeleteUser(user.Phone, user.Password))
            {
                MessageBox.Show("User deleted.");
                var authorization = new Authorization();
                authorization.Show();
                parent.Close();
            }
            else
            {
                MessageBox.Show("Error", "Errorchik.");
            }
            
            
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            parent.MainFrame.Content = null;
        }

        private void ChangeData_Click(object sender, RoutedEventArgs e)
        {
            parent.MainFrame.Content = new ChangeData(user, parent);
        }

        private void ChangePassword_Click(object sender, RoutedEventArgs e)
        {
            parent.MainFrame.Content = new ChangePassword(user, parent);
        }
    }
}
