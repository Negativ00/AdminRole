using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isDark = false;

        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content = new PatientPage();
        }

        private void ThemeChange_Click(object sender, RoutedEventArgs e)
        {

            if (!isDark)
            {
                App.Theme = "DarkTheme";
            }

            else
            {
                App.Theme = "LightTheme";
            }
            isDark = !isDark;
            return;
        }

        private void MinimizeWindowButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void FullWindowButton_Click(object sender, RoutedEventArgs e)
        {
            if(WindowState == WindowState.Maximized)
                WindowState = WindowState.Normal;
            else
                WindowState = WindowState.Maximized;
        }

        private void CloseWindowButton_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
