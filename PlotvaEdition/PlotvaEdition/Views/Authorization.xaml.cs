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
using System.Windows.Shapes;

namespace PlotvaEdition.Views
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        private readonly DBOperationUser dbOperation;
        public Authorization()
        {
            InitializeComponent();
            dbOperation = new DBOperationUser(new DeliveryDbContext());
        }

        private void Autorizate_Click(object sender, RoutedEventArgs e)
        {
            string phone = NumberPhone.Text;
            string password = Password.Text;

            var user = dbOperation.AuthenticateUser(phone, password);
            if (user != null)
            {
                string role = dbOperation.GetUserRole(phone, password);
                if (role == "User")
                {
                    var mainScreenUser = new MainScreenUser(user);
                    mainScreenUser.Show();
                    this.Close();
                }
                else if (role == "Admin")
                {
                    var mainScreenOperator = new MainScreenOperator(user);
                    mainScreenOperator.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("Неправильный номер телефона или пароль.", "Ошибка аутентификации", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            else
            {
                MessageBox.Show("Неправильный номер телефона или пароль.", "Ошибка аутентификации", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            var registration = new Registration();
            registration.Show();
            this.Close();
        }
    }
}
