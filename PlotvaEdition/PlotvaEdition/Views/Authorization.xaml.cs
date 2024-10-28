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
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        DBOperation dbOperation = new DBOperation(new DeliveryDbContext());
        public Authorization()
        {
            InitializeComponent();
        }

        private void Autorizate_Click(object sender, RoutedEventArgs e)
        {
            string phone = NumberPhone.Text;
            string password = Password.Text;
            string role = dbOperation.GetUserRole(phone, password);
            if (dbOperation.AuthenticateUser(phone, password))
            {
                if (role == "User")
                {
                    var mainscreenUser = new MainScreen();

                }
                else if (role == "Admin")
                {

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
