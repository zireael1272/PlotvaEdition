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
    /// Логика взаимодействия для ChangeData.xaml
    /// </summary>
    public partial class ChangeData : Page
    {
        private readonly DBOperationUser dbOperation;
        private Users user;
        private MainScreenUser parent;
        public ChangeData(Users user, MainScreenUser parent)
        {
            InitializeComponent();
            dbOperation = new DBOperationUser(new DeliveryDbContext());
            this.user = user;
            this.parent = parent;
        }

        private void Data_Loaded(object sender, RoutedEventArgs e)
        {
            Name.Text = $"{user.Name}";
            Surname.Text = $"{user.Surname}";
            Patronymic.Text = $"{user.Patronymic}";
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            parent.MainFrame.GoBack();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (dbOperation.UpdateUserDetails(user.Phone, Name.Text, Surname.Text, Patronymic.Text))
            {
                user.Name = Name.Text;
                user.Surname = Surname.Text;
                user.Patronymic = Patronymic.Text;
                parent.MainFrame.GoBack();
            }
        }
    }
}
