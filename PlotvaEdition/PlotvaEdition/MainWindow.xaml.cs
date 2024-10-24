using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
using PlotvaEdition.Interfaces;
using PlotvaEdition.DB;
using PlotvaEdition.Models;


namespace PlotvaEdition
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DBOperation dbOperation = new DBOperation(new DeliveryDbContext());
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Autorizate_Click(object sender, RoutedEventArgs e)
        {
            /*string phone = NumberPhone.Text;
            string password = Password.Text;
            string details = "";

            details = dbOperation.GetUserDetails(phone, password);
            if (details != "")
            {
                MessageBox.Show($"ФИО пользователя: {details}");
            }
            else
            {
                MessageBox.Show("Пользователь не найден или неверные данные.");
            }*/

            string phone = NumberPhone.Text;
            dbOperation.DeleteUser(phone);

        }
    }
}
