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
        private readonly DBOperation dbOperation;
        public Authorization()
        {
            InitializeComponent();
            dbOperation = new DBOperation(new DeliveryDbContext());
        }

        private void Autorizate_Click(object sender, RoutedEventArgs e)
        {
            string phone = NumberPhone.Text;
            string password = Password.Text;

            if (dbOperation.AuthenticateUser(phone, password))
            {
                string role = dbOperation.GetUserRole(phone, password);
                if (role == "User")
                {
                    var mainScreenUser = new MainScreenUser();
                    mainScreenUser.Show();
                    this.Close();
                }
                else if (role == "Admin")
                {
                    var mainScreenOperator = new MainScreenOperator();
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
    }
}
