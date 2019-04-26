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

namespace HappinessProject
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Btn_SignIn_Click(object sender, RoutedEventArgs e)
        {
            //NavigationWindow window = new NavigationWindow();
            //window.Source = new Uri("MainWindow.xaml", null);


        }

        private void Btn_Close_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
