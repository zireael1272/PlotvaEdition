using PlotvaEdition.DB;
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
    /// Логика взаимодействия для MainScreenOperator.xaml
    /// </summary>
    public partial class MainScreenOperator : Window
    {
        private readonly DBOperation dbOperation;
        public MainScreenOperator()
        {
            InitializeComponent();
        }

        private void Account_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("Views/Account.xaml", UriKind.Relative));
        }
    }
}
