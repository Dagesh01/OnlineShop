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

namespace OnlineShop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("Pages/Dashboard.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("Pages/Tables.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("Pages/Profile.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("Pages/Settings.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
