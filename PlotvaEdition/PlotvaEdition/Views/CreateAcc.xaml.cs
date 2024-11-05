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
    /// Логика взаимодействия для CreateAcc.xaml
    /// </summary>
    public partial class CreateAcc : Window
    {
        private readonly DBOperationUser dbOperation;
        private string Phone;
        private string Password;
        public CreateAcc(string number, string password)
        {
            InitializeComponent();
            dbOperation = new DBOperationUser(new DeliveryDbContext());
            Phone = number;
            Password = password;
        }

        private void Createacc_Click(object sender, RoutedEventArgs e)
        {
            string name = Name.Text;
            string surname = Surname.Text;
            string patronymic = Patronymic.Text;
            if(dbOperation.AddUser(Phone, Password, "User", name, surname, patronymic))
            {
                Users newuser = dbOperation.AuthenticateUser(Phone, Password);
                var mainscreenuser = new MainScreenUser(newuser);
                mainscreenuser.Show();
                this.Close();
            }
        }
    }
}
