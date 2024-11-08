﻿using PlotvaEdition.DB;
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
    /// Логика взаимодействия для MainScreenOperator.xaml
    /// </summary>
    public partial class MainScreenOperator : Window
    {
        private readonly DBOperationUser dbOperation;
        private Users user;
        public MainScreenOperator(Users user)
        {
            InitializeComponent();
            this.Width = 800;
            this.Height = 480;
            this.user = user;
        }

    }
}
