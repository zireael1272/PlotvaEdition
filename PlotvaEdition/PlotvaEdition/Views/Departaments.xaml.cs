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
    /// Логика взаимодействия для Departaments.xaml
    /// </summary>
    public partial class Departaments : Page
    {

        private readonly DBOperationUser dbOperation;
        private Users user;
        private MainScreenUser parent;
        private Label selectedDepartment;
        public Departaments(Users user, MainScreenUser parent, Label DepartmentSender)
        {
            InitializeComponent();
            dbOperation = new DBOperationUser(new DeliveryDbContext());
            this.user = user;
            this.parent = parent;
            selectedDepartment = DepartmentSender;
        }

        private void Departaments_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> departments = new List<string> 
            {
                "№ 1 Запоріжжя, вул. Фортечна (ран. Грязнова), 2в (Набережна магістраль)",
                "№ 2 Запоріжжя, вул. Карпенка-Карого, 58",
                "№ 3 Запоріжжя, просп. Соборний, 141",
                "№ 4 Запоріжжя, вул. Гоголя, 163",
                "№ 5 Запоріжжя, просп. Ювілейний, 12",
                "№ 6 Запоріжжя, вул. Музична,2",
                "№ 7 Запоріжжя, просп. Соборний (ран. Леніна), 43",
                "№ 8 Запоріжжя, вул. Водограйна, 7А",
                "№ 9 Запоріжжя, просп. Соборний (ран. Леніна), 208",
                "№ 10 Запоріжжя, вул. Дніпровське шосе, 30",
                "№ 11 Запоріжжя, вул.Хортицьке шосе, 24/вул.Маршала Судця, 2",
                "№ 12 Запоріжжя, просп. Соборний (ран. Леніна), 84",
                "№ 13 Запоріжжя, вул. Авраменка, 13",
                "№ 14 Запоріжжя, вул. Чумаченка, 25"
            };

            ListDepartaments.ItemsSource = departments;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (ListDepartaments.SelectedItem != null)
            {
                selectedDepartment.Content = ListDepartaments.SelectedItem.ToString();
                parent.MainFrame.GoBack();
            }
            else
            {
                MessageBox.Show("Nothing not selected", "Warning");
            }
            
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            parent.MainFrame.GoBack();
        }
    }
}
