using System;
using System.Collections.Generic;
using System.Data;
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
using PlotvaEdition.Models;

namespace PlotvaEdition
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DBOperation dBOperation = new DBOperation();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Autorizate_Click(object sender, RoutedEventArgs e)
        {
            string phone = NumberPhone.Text;
            string password = Password.Text;
            User user = dBOperation.AuthenticateUser(phone, password);
            if (user != null)
            {
                MessageBox.Show("User role: " + user.Role);
            }
            else
            {
                MessageBox.Show("User not found");
            }
        }
    }
}
