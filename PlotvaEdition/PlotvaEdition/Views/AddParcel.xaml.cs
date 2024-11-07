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
    /// Логика взаимодействия для AddParcel.xaml
    /// </summary>
    public partial class AddParcel : Page
    {
        private readonly DBOperationUser dbOperation;
        private Users user;
        private MainScreenUser parent;
        public AddParcel(Users user, MainScreenUser parent)
        {
            InitializeComponent();
            dbOperation = new DBOperationUser(new DeliveryDbContext());
            this.user = user;
            this.parent = parent;
        }

        private void AddParcel_Loaded(object sender, RoutedEventArgs e)
        {
            SenderFullData.Content = user.Phone + "\n" + user.Name + " " + user.Surname + " " + user.Patronymic;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            parent.MainFrame.Content = null;
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if(selectedDepartment.Content == null || DepartmentReceiver.Content == null || ReceiverFullData.Content == null)
            {
                MessageBox.Show("ну ніху не заповнено, ти, бєздарь", "");
            }
            else if(DepartmentReceiver.Content.ToString() == selectedDepartment.Content.ToString())
            {
                MessageBox.Show("ти шо от себе собі перешлеш чепуха", "");
            }
            else
            {
                string SenderDepartament = selectedDepartment.Content.ToString();
                string ReceiverDepartament = DepartmentReceiver.Content.ToString();
                string FullDataReceiver = ReceiverFullData.Content.ToString();
                parent.MainFrame.Content = new ChoiceParameters(user, parent, SenderDepartament, ReceiverDepartament, FullDataReceiver);
            }
        }

        private void DepartmentChoice_Click(object sender, RoutedEventArgs e)
        {
            parent.MainFrame.Content = new Departaments(user, parent, selectedDepartment);
        }

        private void DepartmentReceiverChoice_Click(object sender, RoutedEventArgs e)
        {
            parent.MainFrame.Content = new Departaments(user, parent, DepartmentReceiver);
        }

        private void ReceiverFullDataChoice_Click(object sender, RoutedEventArgs e)
        {
            parent.MainFrame.Content = new InterDataReceiver(user, parent, ReceiverFullData);
        }
    }
}
