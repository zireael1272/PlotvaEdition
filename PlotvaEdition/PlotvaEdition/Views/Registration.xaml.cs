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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        private readonly DBOperationUser dbOperation;
        public Registration()
        {
            InitializeComponent();
            dbOperation = new DBOperationUser(new DeliveryDbContext());
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            string number = Phone.Text;
            string password = Password.Text;
            var createacc = new CreateAcc(number, password);
            createacc.Show();
            this.Close();
        }

        private void Autorizate_Click(object sender, RoutedEventArgs e)
        {
            var authorization = new Authorization();
            authorization.Show();
            this.Close();
        }
    }
}
