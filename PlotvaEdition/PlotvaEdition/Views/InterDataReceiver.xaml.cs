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
    /// Логика взаимодействия для InterDataReceiver.xaml
    /// </summary>
    public partial class InterDataReceiver : Page
    {
        private readonly DBOperationUser dbOperation;
        private Users user;
        private MainScreenUser parent;
        private Label ReceiverData;
        public InterDataReceiver(Users user, MainScreenUser parent, Label ReceiverData)
        {
            InitializeComponent();
            dbOperation = new DBOperationUser(new DeliveryDbContext());
            this.user = user;
            this.parent = parent;
            this.ReceiverData = ReceiverData;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            parent.MainFrame.GoBack();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (PhoneReceiver.Text == "" || Name.Text == "" || Surname.Text == "" || Patronymic.Text == "") {
                MessageBox.Show("Field empty", "Warning");
            }
            else
            {
                ReceiverData.Content = PhoneReceiver.Text + "\n" + Name.Text + " " + Surname.Text + " " + Patronymic.Text;
                parent.MainFrame.GoBack();
            }
        }
    }
}
