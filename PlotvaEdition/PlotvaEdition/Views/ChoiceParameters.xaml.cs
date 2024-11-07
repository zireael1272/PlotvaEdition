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
    /// Логика взаимодействия для ChoiceParameters.xaml
    /// </summary>
    public partial class ChoiceParameters : Page
    {
        private readonly DBOperationUser dbOperation;
        private Users user;
        private MainScreenUser parent;
        private string SenderDepartament;
        private string ReceiverDepartament;
        private string FullDataReceiver;
        public ChoiceParameters(Users user, MainScreenUser parent, string SenderDepartament, string ReceiverDepartament, string FullDataReceiver)
        {
            InitializeComponent();
            dbOperation = new DBOperationUser(new DeliveryDbContext());
            this.user = user;
            this.parent = parent;
            this.SenderDepartament = SenderDepartament;
            this.ReceiverDepartament = ReceiverDepartament;
            this.FullDataReceiver = FullDataReceiver;
        }

        private void WeightSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (WeightSlider.Value == 31)
            {
                SelectedWeight.Text = "Вага посилки: 30+ кг";
            }
            else
            {
                SelectedWeight.Text = $"Вага посилки: {WeightSlider.Value} кг";
            }
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            string[] lines = FullDataReceiver.Split('\n');

            if (lines.Length >= 2)
            {
                string phoneReceiver = lines[0];

                string[] nameParts = lines[1].Split(' ');

                if (nameParts.Length >= 3)
                {
                    string name = nameParts[0];
                    string surname = nameParts[1];
                    string patronymic = nameParts[2];

                }
            }
        }
    }
}
