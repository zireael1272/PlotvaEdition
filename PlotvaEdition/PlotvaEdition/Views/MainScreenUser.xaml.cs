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
    /// Логика взаимодействия для MainScreenUser.xaml
    /// </summary>
    public partial class MainScreenUser : Window
    {
        public MainScreenUser()
        {
            InitializeComponent();
        }

        private void Account_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Account());
        }

        private void HistoryParcel_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new HistoryPackage());
        }

        private void AddParcel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
