﻿using System;
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

namespace AdminRole
{
    /// <summary>
    /// Логика взаимодействия для PatientPage.xaml
    /// </summary>
    public partial class PatientPage : Page
    {
        public PatientPage()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedRole = (RolesComboBox.SelectedItem as ComboBoxItem).Content.ToString();

            if (selectedRole == "Пользователь")
                (Application.Current.MainWindow as MainWindow).MainFrame.Content = new PatientPage();
            else if (selectedRole == "Врач")
                (Application.Current.MainWindow as MainWindow).MainFrame.Content = new DoctorPage();
            else if (selectedRole == "Администратор")
                (Application.Current.MainWindow as MainWindow).MainFrame.Content = new AdminPage();
        }
    }
}
