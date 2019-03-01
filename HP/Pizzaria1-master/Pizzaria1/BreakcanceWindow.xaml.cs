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

namespace Pizzaria1
{
    /// <summary>
    /// Interaction logic for BreakcanceWindow.xaml
    /// </summary>
    public partial class BreakcanceWindow : Window
    {
        public BreakcanceWindow()
        {
            InitializeComponent();
        }

        private void Btn_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_SetUpNextPlan_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Future Functionality. ");
        }
    }
}
