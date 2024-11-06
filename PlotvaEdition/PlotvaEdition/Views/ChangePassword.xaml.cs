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
    /// Логика взаимодействия для ChangePassword.xaml
    /// </summary>
    public partial class ChangePassword : Page
    {
        private readonly DBOperationUser dbOperation;
        private Users user;
        private MainScreenUser parent;
        public ChangePassword(Users user, MainScreenUser parent)
        {
            InitializeComponent();
            dbOperation = new DBOperationUser(new DeliveryDbContext());
            this.user = user;
            this.parent = parent;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            parent.MainFrame.GoBack();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (newPasswordAgain.Text == newPassword.Text && user.Password != newPassword.Text)
            {
                if (dbOperation.UpdatePassword(user.Phone, newPassword.Text))
                {
                    user.Password = newPassword.Text;
                    parent.MainFrame.GoBack();
                }
            }
            else
            {
                MessageBox.Show("Помилка", "Паролі не співпадають");
            }
        }
    }
}
